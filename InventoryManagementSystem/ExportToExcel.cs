using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using InventoryManagementSystem.Models;
using System.Collections.Generic;
using System.IO;

namespace InventoryManagementSystem
{
    public class ExcelExport
    {
        public void ExportToExcel(List<Product> products, string filePath)
        {
            // Create a new Excel document
            using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Create(filePath, SpreadsheetDocumentType.Workbook))
            {
                // Add a WorkbookPart to the document
                WorkbookPart workbookPart = spreadsheetDocument.AddWorkbookPart();
                workbookPart.Workbook = new Workbook();

                // Add a WorksheetPart to the WorkbookPart
                WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                worksheetPart.Worksheet = new Worksheet(new SheetData());

                // Create a new sheet and append it to the workbook
                Sheets sheets = spreadsheetDocument.WorkbookPart.Workbook.AppendChild<Sheets>(new Sheets());
                Sheet sheet = new Sheet() { Id = spreadsheetDocument.WorkbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "Products" };
                sheets.Append(sheet);

                // Create the header row
                SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();
                Row headerRow = new Row();
                headerRow.Append(
                    new Cell() { DataType = CellValues.String, CellValue = new CellValue("Product ID") },
                    new Cell() { DataType = CellValues.String, CellValue = new CellValue("Name") },
                    new Cell() { DataType = CellValues.String, CellValue = new CellValue("Price") },
                    new Cell() { DataType = CellValues.String, CellValue = new CellValue("Description") },
                    new Cell() { DataType = CellValues.String, CellValue = new CellValue("CategoryId") });

                sheetData.AppendChild(headerRow);

                // Add data rows
                foreach (var product in products)
                {
                    Row dataRow = new Row();
                    dataRow.Append(
                        new Cell() { DataType = CellValues.Number, CellValue = new CellValue(product.Id.ToString()) },
                        new Cell() { DataType = CellValues.String, CellValue = new CellValue(product.Name) },
                        new Cell() { DataType = CellValues.Number, CellValue = new CellValue(product.Price.ToString()) },
                        new Cell() { DataType = CellValues.Number, CellValue = new CellValue(product.Description.ToString()) },
                        new Cell() { DataType = CellValues.Number, CellValue = new CellValue(product.CategoryId.ToString()) });


                    sheetData.AppendChild(dataRow);
                }
            }
        }
    }
}
