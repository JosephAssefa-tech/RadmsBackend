//using RadmsEntities;
//using RadmsRepositoryFacade;
//using RadmsServiceFacade;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace RadmsServiceManager
//{
//    public class AccidentImportService : IAccidentImportService
//    {
//        private readonly IAccidentDetailsTransactionRepository _accidentRepository;

//        public AccidentImportService(IAccidentDetailsTransactionRepository accidentRepository)
//        {
//            _accidentRepository = accidentRepository;
//        }
//        public async Task ImportAccidentsFromXlsx(byte[] fileData)
//        {
//            // Perform the necessary parsing and data extraction from the XLSX file
//            // Iterate over the rows and create Accident instances from the data
//            List<AccidentDetailsTransactionEntity> accidents = ParseAccidentsFromXlsx(fileData);

//            // Insert the Accident records into the database
//            foreach (var accident in accidents)
//            {
//                await _accidentRepository.AddAccidentAsync(accident);
//            }
//        }
//        private List<AccidentDetailsTransactionEntity> ParseAccidentsFromXlsx(byte[] fileData)
//        {
//            // Implement the parsing logic here to extract Accident data from the XLSX file
//            // You can use libraries like EPPlus, ClosedXML, or any other suitable library for parsing XLSX files

//            // Example implementation using EPPlus:
//            using (var package = new ExcelPackage(new MemoryStream(fileData)))
//            {
//                var worksheet = package.Workbook.Worksheets[1]; // Assuming the data is in the first worksheet
//                var rowCount = worksheet.Dimension.Rows;

//                List<Accident> accidents = new List<Accident>();

//                for (int row = 2; row <= rowCount; row++) // Start from row 2 (assuming headers are in row 1)
//                {
//                    var accidentId = worksheet.Cells[row, 1].GetValue<int>();
//                    var accidentName = worksheet.Cells[row, 2].GetValue<string>();
//                    var location = worksheet.Cells[row, 3].GetValue<string>();

//                    var accident = new Accident
//                    {
//                        AccidentId = accidentId,
//                        AccidentName = accidentName,
//                        Location = location
//                        // Set other properties as needed
//                    };

//                    accidents.Add(accident);
//                }

//                return accidents;
//            }
//        }
//    }
//}
