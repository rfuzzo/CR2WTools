using RED.Reflection;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;

namespace RED.Core
{
    public class C2dArray : CResource
    {
        #region Protected RED Props
        [RED(12, 0)]
        private protected TDynArray<string> headers;
        [RED(12, 0, 12, 0)]
        private protected TDynArray<TDynArray<string>> data;
        #endregion

        public string GetValueAt(int collumn, int row)
        {
            if (collumn >= headers.Count || collumn < 0)
                return null;
            if (row >= data.Count || row < 0)
                return null;

            return data[row][collumn];
        }

        public string GetValue(string header, int row)
        {
            var collumn = headers.IndexOf(header);
            return GetValueAt(collumn, row);
        }

        public int GetRowIndexAt(int collumn, string value)
        {
            for (int row = 0; row < data.Count; row++)
            {
                if(data[row][collumn] == value)
                {
                    return row;
                }
            }
            return -1;
        }

        public int GetRowIndex(string header, string value)
        {
            var collumn = headers.IndexOf(header);
            if (collumn == -1)
                return -1;
            return GetRowIndexAt(collumn, value);
        }

        public int GetNumRows()
        {
            return data.Count;
        }

        public void SetValueAt(int row, int collumn, string value)
        {
            if (collumn >= headers.Count || collumn < 0)
                return;
            if (row >= GetNumRows() || row < 0)
                return;

            if (value.Contains(';'))
                return;

            data[row][collumn] = value;
        }

        public void SetValue(string header, int row, string value)
        {
            var collumn = headers.IndexOf(header);
            SetValueAt(row, collumn, value);
        }

        public void AddCollumn(string headerName)
        {
            if (string.IsNullOrWhiteSpace(headerName))
                return;

            headers.Add(headerName);

            for (int i = 0; i < data.Count; i++)
            {
                data[i].Add(string.Empty);
            }
        }

        public void AddRow()
        {
            var row = new TDynArray<string>();
            for (int i = 0; i < headers.Count; i++)
                row.Add(string.Empty);
            data.Add(row);
        }

        public void ImportCSV(string filePath)
        {
            if (!File.Exists(filePath))
                return;

            if (Path.GetExtension(filePath) != ".csv")
                return;

            ImportFileTimeStamp = CDateTime.Now;
            ImportFile = filePath;

            var lines = File.ReadAllLines(filePath);

            var strings = lines.Select(line => line.Split(';')).ToArray();
            var width = strings[0].Length;
            var height = strings.Length;

            var grid = new string[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    string value;
                    try
                    {
                        value = strings[i][j];
                    }
                    catch
                    {
                        value = string.Empty;
                    }
                    grid[i, j] = value;
                }
            }

            this.headers = new TDynArray<string>();
            for (int i = 0; i < width; i++)
            {
                this.headers.Add(grid[0,i]);
            }
            this.data = new TDynArray<TDynArray<string>>();
            for (int i = 1; i < height; i++)
            {
                var row = new TDynArray<string>();
                for (int j = 0; j < width; j++)
                {
                    row.Add(grid[i,j]);
                }
                this.data.Add(row);
            }
        }

        public void ExportCSV(string filePath)
        {
            var fs = new StreamWriter(filePath);

            fs.WriteLine(string.Join(";", headers));
            fs.Flush();

            for (int i = 0; i < data.Count; i++)
            {
                fs.WriteLine(string.Join(";", data[i]));
                fs.Flush();
            }

            fs.Close();
        }
    }
}