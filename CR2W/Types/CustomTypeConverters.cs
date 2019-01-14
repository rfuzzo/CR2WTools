using System;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections;
using System.Globalization;
using CR2W.Types.W3;
using System.Collections.Generic;

namespace CR2W.Types
{
    #region List Converter
    public class ExpandableCollectionPropertyDescriptor : PropertyDescriptor
    {
        private IList collection;
        private readonly int _index;

        public ExpandableCollectionPropertyDescriptor(IList coll, int idx)
            : base(GetDisplayName(coll, idx), null)
        {
            collection = coll;
            _index = idx;
        }

        private static string GetDisplayName(IList list, int index)
        {
            int width = (list.Count + 1).ToString("d").Length;
            return "[" + index.ToString($"D{width}") + "]  " + CSharpName(list[index].GetType());
        }

        private static string CSharpName(Type type)
        {
            var sb = new StringBuilder();
            var name = type.Name;
            if (!type.IsGenericType)
                return name;
            sb.Append(name.Substring(0, name.IndexOf('`')));
            sb.Append("<");
            sb.Append(string.Join(", ", type.GetGenericArguments()
                                            .Select(CSharpName)));
            sb.Append(">");
            return sb.ToString();
        }

        public override bool CanResetValue(object component)
        {
            return true;
        }

        public override Type ComponentType
        {
            get { return this.collection.GetType(); }
        }

        public override object GetValue(object component)
        {
            return collection[_index];
        }

        public override bool IsReadOnly
        {
            get { return false; }
        }

        public override string Name
        {
            get { return _index.ToString(CultureInfo.InvariantCulture); }
        }

        public override Type PropertyType
        {
            get { return collection[_index].GetType(); }
        }

        public override void ResetValue(object component)
        {
        }

        public override bool ShouldSerializeValue(object component)
        {
            return true;
        }

        public override void SetValue(object component, object value)
        {
            collection[_index] = value;
        }
    }

    public class ListConverter : CollectionConverter
    {
        public override bool GetPropertiesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            IList list = value as IList;
            if (list == null || list.Count == 0)
                return base.GetProperties(context, value, attributes);

            var items = new PropertyDescriptorCollection(null);
            for (int i = 0; i < list.Count; i++)
            {
                object item = list[i];
                items.Add(new ExpandableCollectionPropertyDescriptor(list, i));
            }
            //items.Sort();
            return items;
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (value is IList)
            {
                string displayText = "";
                string myListElementType = ((IList)value).GetType().GetGenericArguments().Single().ToString().Split('.').Last();
                displayText = $"{myListElementType}: {((IList)value).Count.ToString()}";
                return displayText;
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }

    }
    #endregion

    #region PointerConverter
    public class PointerConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            string result = "";

            string idx = value.GetType().GetProperty("Index").GetValue(value).ToString();
            Type type = (Type)value.GetType().GetProperty("PointerType").GetValue(value);
            string pointerType = type.Name.ToString();

            if ( destinationType == typeof(string))
                result = $"Ptr<{pointerType}:  {idx}>";

            return result ?? base.ConvertTo(context, culture, value, destinationType);
        }
    }
    #endregion

    #region HandleConverter
    public class HandleConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            string result = "";
            Type type = (Type)value.GetType().GetProperty("HandleOf").GetValue(value);
            string handleOf = type?.Name.ToString();

            string handletype = value.GetType().GetProperty("HandleType").GetValue(value)?.ToString();
            if (handletype == "ReferenceHandle")
            {
                string index = value.GetType().GetProperty("Index").GetValue(value)?.ToString();

                if (destinationType == typeof(string))
                    result = $"{handletype}<{handleOf}:  {index}>";
            }
            else //ResourceHandle
            {
                string depotPath = value.GetType().GetProperty("DepotPath").GetValue(value)?.ToString();

                if (destinationType == typeof(string))
                    result = $"{handletype}<{handleOf}:  {depotPath}>";
            }

            return result ?? base.ConvertTo(context, culture, value, destinationType);
        }
    }
    #endregion

    #region VirtualDictConverter
    public class VirtualDictConverter : CollectionConverter
    {
        public override bool GetPropertiesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            ICollection<CObject> vals = (ICollection<CObject>)(value.GetType().GetProperty("Values").GetValue(value));
            IList list = vals.ToList();
            

            if (list == null || list.Count == 0)
                return base.GetProperties(context, value, attributes);

            var items = new PropertyDescriptorCollection(null);
            for (int i = 0; i < list.Count; i++)
            {
                object item = list[i];
                items.Add(new ExpandableCollectionPropertyDescriptor(list, i));
            }
            return items;
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            ICollection<CObject> vals = (ICollection<CObject>)(value.GetType().GetProperty("Values").GetValue(value));
            IList list = vals.ToList();

            if (list is IList)
            {
                string displayText = "";
                string myListElementType = ((IList)list).GetType().GetGenericArguments().Single().ToString().Split('.').Last();
                displayText = $"{myListElementType}: {((IList)list).Count.ToString()}";
                return displayText;
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
    #endregion

}
