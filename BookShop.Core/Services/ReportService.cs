using BookShop.Core.Models.Context;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BookShop.Core.Services
{
    public enum ReportType
    {
        Services = 1,
        Customers,
        Orders
    }

    public class ReportService
    {
        private readonly EnterpriseContext _context;

        static ReportService()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        public ReportService(EnterpriseContext context)
        {
            _context = context;
        }

        public bool CreateReport(ReportType type, string folder, string author, DateTime? start, DateTime? end)
        {
            try
            {
                switch (type)
                {
                    case ReportType.Services: CreateReportOfServices(folder, author, start, end); break;
                    case ReportType.Customers: CreateReportOfCustomers(folder, author, start, end); break;
                    case ReportType.Orders: CreateReportOfOrders(folder, author, start, end); break;
                    default: break;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        #region Services

        private IEnumerable<ServiceReportRecord> GetServiceRecords(DateTime? start, DateTime? end)
        {
            var result = new List<ServiceReportRecord>();

            var orderItems = _context.OrderItem.ToList();

            if (start.HasValue)
                orderItems = orderItems.Where(x => DateTime.Parse(x.Order.DateCreated) >= start).ToList();

            if (end.HasValue)
                orderItems = orderItems.Where(x => DateTime.Parse(x.Order.DateCreated) <= start).ToList();

            var groupedOrderItems = orderItems.GroupBy(x => x.Product, y => y.Product).OrderByDescending(x => x.Count());

            foreach (var group in groupedOrderItems)
            {
                result.Add(
                    new ServiceReportRecord
                    {
                        Name = group.Key.Product.Title,
                        DateCreated = group.Key.Product.DateCreated,
                        Price = group.Key.Price,
                        Count = group.Count(),
                        SumPrice = group.Sum(x => x.Price)
                    });
            }

            return result;
        }

        private void CreateReportOfServices(string folder, string author, DateTime? start, DateTime? end)
        {
            var filename = Path.Combine(folder, $"Рейтинг послуг {DateTime.Now:d}.xlsx");

            using (ExcelPackage excelPackage = CreateExcelPackage(filename, author, "Рейтинг послуг"))
            {
                var workSheet = excelPackage.Workbook.Worksheets.Add("Рейтинг послуг");

                workSheet.Cells["A1:M1"].Merge = true;
                workSheet.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                workSheet.Cells["A1"].Style.Font.Bold = true;
                workSheet.Cells["A1"].Style.Font.Size = 14;
                workSheet.Cells["A1"].Value = $"Рейтинг послуг ({start} - {end})";

                workSheet.Cells["A2:E2"].Merge = true;
                workSheet.Cells["A2:E2"].Value = "Назва книги";
                workSheet.Cells["A2:E2"].Style.Font.Bold = true;

                workSheet.Cells["F2:G2"].Merge = true;
                workSheet.Cells["F2:G2"].Value = "Додана";
                workSheet.Cells["F2:G2"].Style.Font.Bold = true;

                workSheet.Cells["H2:I2"].Merge = true;
                workSheet.Cells["H2:I2"].Value = "Вартість";
                workSheet.Cells["H2:I2"].Style.Font.Bold = true;

                workSheet.Cells["J2:K2"].Merge = true;
                workSheet.Cells["J2:K2"].Value = "Продано";
                workSheet.Cells["J2:K2"].Style.Font.Bold = true;

                workSheet.Cells["L2:M2"].Merge = true;
                workSheet.Cells["L2:M2"].Value = "Сума";
                workSheet.Cells["L2:M2"].Style.Font.Bold = true;

                int line = 3;
                var items = GetServiceRecords(start, end);
                foreach (var item in items)
                {
                    workSheet.Cells[$"A{line}:E{line}"].Merge = true;
                    workSheet.Cells[$"A{line}:E{line}"].Value = item.Name;

                    workSheet.Cells[$"F{line}:G{line}"].Merge = true;
                    workSheet.Cells[$"F{line}:G{line}"].Value = item.DateCreated;

                    workSheet.Cells[$"H{line}:I{line}"].Merge = true;
                    workSheet.Cells[$"H{line}:I{line}"].Style.Numberformat.Format = @"0,00 грн";
                    workSheet.Cells[$"H{line}:I{line}"].Value = item.Price;

                    workSheet.Cells[$"J{line}:K{line}"].Merge = true;
                    workSheet.Cells[$"J{line}:K{line}"].Value = item.Count;

                    workSheet.Cells[$"L{line}:M{line}"].Merge = true;
                    workSheet.Cells[$"L{line}:M{line}"].Style.Numberformat.Format = @"0,00 грн";
                    workSheet.Cells[$"L{line}:M{line}"].Value = item.SumPrice;

                    line++;
                }

                excelPackage.Save();
            }
        }

        #endregion

        #region Customers

        private IEnumerable<CustomerReportRecord> GetCustomerRecords(DateTime? start, DateTime? end)
        {
            var result = new List<CustomerReportRecord>();

            var orderItems = _context.OrderItem.ToList();

            if (start.HasValue)
                orderItems = orderItems.Where(x => DateTime.Parse(x.Order.DateCreated) >= start).ToList();

            if (end.HasValue)
                orderItems = orderItems.Where(x => DateTime.Parse(x.Order.DateCreated) <= start).ToList();

            var groupedOrderItems = orderItems.GroupBy(x => x.Order.Customer).OrderByDescending(x => x.Count());

            foreach (var group in groupedOrderItems)
            {
                result.Add(
                    new CustomerReportRecord
                    {
                        FIO = string.Join(" ", group.Key.Surname, group.Key.Name, group.Key.Patronumic),
                        Count = group.Count(),
                        Sum = group.Sum(x => x.Product.Price)
                    });
            }

            return result;
        }

        private void CreateReportOfCustomers(string folder, string author, DateTime? start, DateTime? end)
        {
            var filename = Path.Combine(folder, $"Рейтинг клієнтів {DateTime.Now:d}.xlsx");

            using (ExcelPackage excelPackage = CreateExcelPackage(filename, author, "Рейтинг клієнтів"))
            {
                var workSheet = excelPackage.Workbook.Worksheets.Add("Рейтинг клієнтів");

                workSheet.Cells["A1:I1"].Merge = true;
                workSheet.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                workSheet.Cells["A1"].Style.Font.Bold = true;
                workSheet.Cells["A1"].Style.Font.Size = 14;
                workSheet.Cells["A1"].Value = $"Рейтинг клієнтів ({start} - {end})";

                workSheet.Cells["A2:E2"].Merge = true;
                workSheet.Cells["A2:E2"].Value = "ПІБ";
                workSheet.Cells["A2:E2"].Style.Font.Bold = true;

                workSheet.Cells["F2:G2"].Merge = true;
                workSheet.Cells["F2:G2"].Value = "Куплено книг";
                workSheet.Cells["F2:G2"].Style.Font.Bold = true;

                workSheet.Cells["H2:I2"].Merge = true;
                workSheet.Cells["H2:I2"].Value = "Сума";
                workSheet.Cells["H2:I2"].Style.Font.Bold = true;

                int line = 3;
                var items = GetCustomerRecords(start, end);
                foreach (var item in items)
                {
                    workSheet.Cells[$"A{line}:E{line}"].Merge = true;
                    workSheet.Cells[$"A{line}:E{line}"].Value = item.FIO;

                    workSheet.Cells[$"F{line}:G{line}"].Merge = true;
                    workSheet.Cells[$"F{line}:G{line}"].Value = item.Count;

                    workSheet.Cells[$"H{line}:I{line}"].Merge = true;
                    workSheet.Cells[$"H{line}:I{line}"].Style.Numberformat.Format = @"0,00 грн";
                    workSheet.Cells[$"H{line}:I{line}"].Value = item.Sum;

                    line++;
                }
                var file = new FileInfo(filename);

                excelPackage.SaveAs(file);
            }
        }

        #endregion

        #region Orders

        private IEnumerable<OrderReportRecord> GetOrderRecords(DateTime? start, DateTime? end)
        {
            var result = new List<OrderReportRecord>();

            var orderItems = _context.OrderItem.ToList();

            if (start.HasValue)
                orderItems = orderItems.Where(x => DateTime.Parse(x.Order.DateCreated) >= start).ToList();

            if (end.HasValue)
                orderItems = orderItems.Where(x => DateTime.Parse(x.Order.DateCreated) <= start).ToList();

            var groupedOrders = orderItems.GroupBy(x => x.Order).OrderByDescending(x => DateTime.Parse(x.Key.DateCreated)).Reverse();

            foreach (var group in groupedOrders.Where(x => !string.IsNullOrEmpty(x.Key.DateClosed)))
            {
                result.Add(
                    new OrderReportRecord
                    {
                        CustomerFIO = string.Join(" ", group.Key.Customer.Surname, group.Key.Customer.Name, group.Key.Customer.Patronumic),
                        EmpoyeeFIO = string.Join(" ", group.Key.Employee.Surname, group.Key.Employee.Name, group.Key.Employee.Patronymic),
                        DateCreated = group.Key.DateCreated,
                        DateClosed = group.Key.DateClosed,
                        CountOfPositions = group.Key.OrderItem.Count,
                        Sum = group.Key.OrderItem.Sum(x => x.Product.Price)
                    });
            }

            return result;
        }

        private void CreateReportOfOrders(string folder, string author, DateTime? start, DateTime? end)
        {
            var filename = Path.Combine(folder, $"Замовлення {DateTime.Now:d}.xlsx");

            using (ExcelPackage excelPackage = CreateExcelPackage(filename, author, "Замовлення"))
            {
                var workSheet = excelPackage.Workbook.Worksheets.Add("Замовлення");

                workSheet.Cells["A1:P1"].Merge = true;
                workSheet.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                workSheet.Cells["A1"].Style.Font.Bold = true;
                workSheet.Cells["A1"].Style.Font.Size = 14;
                workSheet.Cells["A1"].Value = $"Замовлення ({start} - {end})";

                workSheet.Cells["A2:D2"].Merge = true;
                workSheet.Cells["A2:D2"].Value = "Клієнт";
                workSheet.Cells["A2:D2"].Style.Font.Bold = true;

                workSheet.Cells["E2:H2"].Merge = true;
                workSheet.Cells["E2:H2"].Value = "Продавець";
                workSheet.Cells["E2:H2"].Style.Font.Bold = true;

                workSheet.Cells["I2:J2"].Merge = true;
                workSheet.Cells["I2:J2"].Value = "К-сть книг";
                workSheet.Cells["I2:J2"].Style.Font.Bold = true;

                workSheet.Cells["K2:L2"].Merge = true;
                workSheet.Cells["K2:L2"].Value = "Сума";
                workSheet.Cells["K2:L2"].Style.Font.Bold = true;

                workSheet.Cells["M2:N2"].Merge = true;
                workSheet.Cells["M2:N2"].Value = "Створене";
                workSheet.Cells["M2:N2"].Style.Font.Bold = true;

                workSheet.Cells["O2:P2"].Merge = true;
                workSheet.Cells["O2:P2"].Value = "Закрите";
                workSheet.Cells["O2:P2"].Style.Font.Bold = true;

                int line = 3;
                var items = GetOrderRecords(start, end);
                foreach (var item in items)
                {
                    workSheet.Cells[$"A{line}:D{line}"].Merge = true;
                    workSheet.Cells[$"A{line}:D{line}"].Value = item.CustomerFIO;

                    workSheet.Cells[$"E{line}:H{line}"].Merge = true;
                    workSheet.Cells[$"E{line}:H{line}"].Value = item.EmpoyeeFIO;

                    workSheet.Cells[$"I{line}:J{line}"].Merge = true;
                    workSheet.Cells[$"I{line}:J{line}"].Value = item.CountOfPositions;

                    workSheet.Cells[$"K{line}:L{line}"].Merge = true;
                    workSheet.Cells[$"K{line}:L{line}"].Style.Numberformat.Format = @"0,00 грн";
                    workSheet.Cells[$"K{line}:L{line}"].Value = item.Sum;

                    workSheet.Cells[$"M{line}:N{line}"].Merge = true;
                    workSheet.Cells[$"M{line}:N{line}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    workSheet.Cells[$"M{line}:N{line}"].Value = item.DateCreated;

                    workSheet.Cells[$"O{line}:P{line}"].Merge = true;
                    workSheet.Cells[$"O{line}:P{line}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    workSheet.Cells[$"O{line}:P{line}"].Value = item.DateClosed;

                    line++;
                }
                var file = new FileInfo(filename);

                excelPackage.SaveAs(file);
            }
        }

        #endregion

        private ExcelPackage CreateExcelPackage(string filename, string author, string title)
        {
            File.Delete(filename);

            var ep = new ExcelPackage(new FileInfo(filename));
            ep.Workbook.Properties.Author = author;
            ep.Workbook.Properties.Title = title;
            ep.Workbook.Properties.Created = DateTime.Now;

            return ep;
        }
    }

    public class ServiceReportRecord
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string DateCreated { get; set; }
        public int Count { get; set; }
        public double SumPrice { get; set; }
    }

    public class CustomerReportRecord
    {
        public string FIO { get; set; }
        public int Count { get; set; }
        public double Sum { get; set; }
    }

    public class OrderReportRecord
    {
        public string CustomerFIO { get; set; }
        public string EmpoyeeFIO { get; set; }
        public int CountOfPositions { get; set; }
        public double Sum { get; set; }
        public string DateClosed { get; set; }
        public string DateCreated { get; set; }
    }
}
