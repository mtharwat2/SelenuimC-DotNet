﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using ExcelDataReader;


namespace SmartPatrolFramework.Helpers
{










    public class ExcelHelpers
    {
        private static List<Datacollection> _dataCol = new List<Datacollection>();


        /// <summary>
        /// Storing all the excel values in to the in-memory collections
        /// </summary>
        /// <param name="fileName"></param>
        public static void PopulateInCollection(string fileName)
        {
            DataTable table = ExcelToDataTable(fileName);

            //Iterate through the rows and columns of the Table
            for (int row = 1; row < table.Rows.Count; row++)
            {
                for (int col = 0; col < table.Columns.Count; col++)
                {
                    Datacollection dtTable = new Datacollection()
                    {
                        RowNumber = row,
                        ColName = table.Columns[col].ColumnName,
                        ColValue = table.Rows[row - 1][col].ToString()
                    };
                    //Add all the details for each row
                    _dataCol.Add(dtTable);
                }
            }
        }

        /// <summary>
        /// Reading all the datas from Excelsheet
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        //private static DataTable ExcelToDataTable(string fileName)
        //{
        //    //open file and returns as Stream
        //    FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
        //    //Createopenxmlreader via ExcelReaderFactory
        //    IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream); //.xlsx
        //    //Set the First Row as Column Name
        //    // excelReader.IsFirstRowAsColumnName = true;
        //    var result = excelReader.AsDataSet(new ExcelDataSetConfiguration()
        //    {
        //        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
        //        {
        //            UseHeaderRow = true
        //        }
        //    });
        //    //Return as DataSet
        //    //DataSet result = excelReader.AsDataSet();
        //    //Get all the Tables
        //    DataTableCollection table = result.Tables;
        //    //Store it in DataTable
        //    DataTable resultTable = table["Sheet1"];
        //    //return
        //    return resultTable;
        //}


        //new Code need to check
        public static DataTable ExcelToDataTable(string fileName)
        {
            using (var stream = File.Open(fileName, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (data) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });


                    // Code updating and working
                    //public static DataTable ExcelToDataTable(string fileName)
                    //{
                    //    System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

                    //    using (var stream = File.Open(fileName, FileMode.Open, FileAccess.Read))
                    //    {
                    //        using (var reader = ExcelReaderFactory.CreateReader(stream))
                    //        {
                    //            var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    //            {
                    //                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                    //                {
                    //                    UseHeaderRow = true
                    //                }
                    //            }) ;




                    //Get all the Tables
                    DataTableCollection table = result.Tables;
                    //Store it in DataTable
                    DataTable resultTable = table["Sheet1"];
                    //return
                    return resultTable;
                }
            }
        }

        public static string ReadData(int rowNumber, string columnName)
        {
            try
            {
                //Retriving Data using LINQ to reduce much of iterations
                string data = (from colData in _dataCol
                               where colData.ColName == columnName && colData.RowNumber == rowNumber
                               select colData.ColValue).SingleOrDefault();

                //var datas = dataCol.Where(x => x.colName == columnName && x.rowNumber == rowNumber).SingleOrDefault().colValue;
                return data.ToString();
            }
            catch (Exception e)
            {
                return null;
            }
        }

    }

    public class Datacollection
    {
        public int RowNumber { get; set; }
        public string ColName { get; set; }
        public string ColValue { get; set; }
    }
}
