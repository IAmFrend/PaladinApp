using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using PaladinApp;
using System.Threading;
using System.Diagnostics;
//Библиотеки под псевдонимом пространства имён
using word = Microsoft.Office.Interop.Word;
using excel = Microsoft.Office.Interop.Excel;

namespace PaladinApp
{
    class Document_class
    {
        ///<summary>
        ///Список доступных видов отчётов.
        ///</summary>
        internal enum Document_Type
        {
            Newcoming, Timetable
        }
        ///<summary>
        ///Список доступных форматов отчётов.
        ///</summary>
        internal enum Document_Format
        {
            Word, Excel, PDF
        }
        ///<summary>
        ///Процедура формирования документа
        ///</summary>
        ///<param name="type">Тип документа</param>
        ///<param name="format">Формат документа</param>
        ///<param name="name">Название документа</param>
        ///<param name="table">результирующая таблица</param>
        public void Document_Create(Document_Type type, Document_Format format, string name, DataTable table)
        {
            //Получение данных о документе
            Configuration_class configuration_Class = new Configuration_class();
            configuration_Class.Document_Configuration_Get();
            switch (name != "" || name != null)
            {
                case true:
                    switch (format)
                    {
                        case (Document_Format.Word)|(Document_Format.PDF):
                            //Открытие приложения и документа в нём
                            word.Application application = new word.Application();
                            word.Document document = application.Documents.Add(Visible: true);
                            //Формирование документа
                            try
                            {
                                //Начало
                                word.Range range = document.Range(0, 0);
                                //Поля
                                document.Sections.PageSetup.LeftMargin = application.CentimetersToPoints((float)Configuration_class.doc_Left_Merge);
                                document.Sections.PageSetup.RightMargin = application.CentimetersToPoints((float)Configuration_class.doc_Right_Merge);
                                document.Sections.PageSetup.TopMargin = application.CentimetersToPoints((float)Configuration_class.doc_Top_Merge);
                                document.Sections.PageSetup.BottomMargin = application.CentimetersToPoints((float)Configuration_class.doc_Bottom_Merge);
                                //Присвоение текстового значения в абзац
                                range.Text = Configuration_class.Organization_Name;
                                //Выравнивание
                                range.ParagraphFormat.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
                                //Интервалы в абзаце
                                range.ParagraphFormat.SpaceAfter = 1;
                                range.ParagraphFormat.SpaceBefore = 1;
                                range.ParagraphFormat.LineSpacingRule = word.WdLineSpacing.wdLineSpaceSingle;
                                //Шрифт
                                range.Font.Name = "Times New Roman";
                                range.Font.Size = 12;
                                //Параграф (один Enter)
                                document.Paragraphs.Add();
                                document.Paragraphs.Add();
                                document.Paragraphs.Add();
                                //Название документа
                                word.Paragraph Document_Name = document.Paragraphs.Add();
                                //Настройка параграфа
                                Document_Name.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
                                Document_Name.Range.Font.Name = "Times New Roman";
                                Document_Name.Range.Font.Size = 16;
                                switch (type)
                                {
                                    case Document_Type.Newcoming:
                                        Document_Name.Range.Text = "Данные посещения";
                                            break;
                                    case Document_Type.Timetable:
                                        Document_Name.Range.Text = "Расписание";
                                            break;
                                }
                                document.Paragraphs.Add();
                                document.Paragraphs.Add();
                                document.Paragraphs.Add();
                                //Создание таблицы
                                word.Paragraph statparg = document.Paragraphs.Add();
                                word.Table stat_table = document.Tables.Add(statparg.Range, table.Rows.Count, table.Columns.Count);
                                //Настройка таблицы
                                stat_table.Borders.InsideLineStyle = word.WdLineStyle.wdLineStyleSingle;
                                stat_table.Borders.OutsideLineStyle = word.WdLineStyle.wdLineStyleSingle;
                                stat_table.Rows.Alignment = word.WdRowAlignment.wdAlignRowCenter;
                                stat_table.Range.Cells.VerticalAlignment = word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                stat_table.Range.Font.Size = 11;
                                stat_table.Range.Font.Name = "Times New Roman";
                                //Заполнение таблицы
                                for (int row = 1; row <=table.Rows.Count;row++)
                                    for (int col = 1; col <= table.Columns.Count; col++)
                                    {
                                        stat_table.Cell(row, col).Range.Text = table.Rows[row - 1][col - 1].ToString();
                                    }
                                document.Paragraphs.Add();
                                document.Paragraphs.Add();
                                document.Paragraphs.Add();
                                //Строка даты создания
                                word.Paragraph Footparg = document.Paragraphs.Add();
                                Footparg.Range.Text = string.Format("Дата создания \t\t\t{0}", DateTime.Now.ToString());
                            }
                            catch
                            {

                            }
                            finally
                            {
                                //Сохранение документа
                                switch (format)
                                {
                                    case (Document_Format.Word):
                                        document.SaveAs2(name, word.WdSaveFormat.wdFormatDocument);
                                        break;
                                    case (Document_Format.PDF):
                                        document.SaveAs2(name, word.WdSaveFormat.wdFormatPDF);
                                        break;
                                }
                                //Закрытие документа
                                document.Close();
                                application.Quit();
                            }
                            break;
                        case Document_Format.Excel:
                            //Открытие приложения, создание документа (книги) и листа в нём.
                            excel.Application application_ex = new excel.Application();
                            excel.Workbook workbook = application_ex.Workbooks.Add();
                            excel.Worksheet worksheet = (excel.Worksheet)workbook.ActiveSheet;
                            try
                            {
                                switch (type)
                                {
                                    case (Document_Type.Newcoming):
                                        worksheet.Name = "Посещение";
                                        //Заполнение таблицы
                                        for (int row = 0; row < table.Rows.Count; row++)
                                            for (int col = 0; col < table.Columns.Count; col++)
                                            {
                                                worksheet.Cells[row+1, col+1].Range.Text = table.Rows[row][col].ToString();
                                            }
                                        //Работа со стилем таблицы
                                        excel.Range border = worksheet.Range[worksheet.Cells[1,1], worksheet.Cells[table.Rows.Count + 1][table.Columns.Count + 1]];
                                        border.Borders.LineStyle = excel.XlLineStyle.xlContinuous;
                                        border.VerticalAlignment = excel.XlVAlign.xlVAlignCenter;
                                        border.HorizontalAlignment = excel.XlHAlign.xlHAlignCenter;
                                        //Дата документа
                                        worksheet.Cells[table.Rows.Count + 3][2] = string.Format("Дата создания {0}", DateTime.Now.ToString());
                                        //Объединение ячеек
                                        worksheet.Range[worksheet.Cells[table.Rows.Count + 3, 2], worksheet.Cells[table.Rows.Count + 3, table.Columns.Count + 2]].Merge();
                                        break;
                                    case (Document_Type.Timetable):
                                        worksheet.Name = "Расписание";
                                        //Заполнение таблицы
                                        for (int row = 0; row < table.Rows.Count; row++)
                                            for (int col = 0; col < table.Columns.Count; col++)
                                            {
                                                worksheet.Cells[row + 1, col + 1].Range.Text = table.Rows[row][col].ToString();
                                            }
                                        //Работа со стилем таблицы
                                        excel.Range border1 = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[table.Rows.Count + 1][table.Columns.Count + 1]];
                                        border1.Borders.LineStyle = excel.XlLineStyle.xlContinuous;
                                        border1.VerticalAlignment = excel.XlVAlign.xlVAlignCenter;
                                        border1.HorizontalAlignment = excel.XlHAlign.xlHAlignCenter;
                                        //Дата документа 
                                        worksheet.Cells[table.Rows.Count + 3][2] = string.Format("Дата создания {0}", DateTime.Now.ToString());
                                        //Объединение ячеек
                                        worksheet.Range[worksheet.Cells[table.Rows.Count + 3, 2], worksheet.Cells[table.Rows.Count + 3, table.Columns.Count + 2]].Merge();
                                        break;
                                }
                            }
                            catch (Exception ex)
                            {
                                System.Windows.Forms.MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                                //Сохранение и выход
                                workbook.SaveAs(name, application_ex.DefaultSaveFormat);
                                workbook.Close();
                                application_ex.Quit();
                            }
                            break;
                    }
                    break;
                case false:
                    System.Windows.Forms.MessageBox.Show("Введите название документа");
                    break;
            }
        }
    }
}
