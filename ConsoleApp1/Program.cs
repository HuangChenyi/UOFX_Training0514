using Ede.Uofx.PubApi.Sdk.NetStd.Models.Base;
using Ede.Uofx.PubApi.Sdk.NetStd.Service;

namespace ConsoleApp1
{
    internal class Program
    {
        async static Task Main(string[] args)
        {
            UofxService.UofxServerUrl = "https://demox3.edetw.com/";

            UofxService.Key = "eyJDbGllbnRJZCI6ImM5OGRlNDkxLTQ5NTItNDJhZC00MmZmLTA4ZGM3NDJmNTIxNSIsIlByaXZhdGVLZXkiOiJQRkpUUVV0bGVWWmhiSFZsUGp4TmIyUjFiSFZ6UG5odWRGWmlTRzlxWjJKd1pXcFZiVTV5YWpCemJqYzVTWEJ5WWk5MWNuVnJZamRpVWpWWE5Dc3lTa0pZVGpaMFFrWjFlRWRwTVhKM2JHbERWbEpqUld3ek4yTkpRamszWm5reFZWZHhSM05OYmk5aGVVWkNOaTloVUZoR05EaGtZekJpU2xkNFdtRlBhR2xZZUVwTFUyTlhZbVJxVjFCSU5scHRUbWhrWTAwelQzWXdLM2xqVWxOWk4wUkNZbE5US3pWdVpWbGlRbFZ2Um5adFoySlRUbkJXVG10aFlYSm1NSGxyY3owOEwwMXZaSFZzZFhNXHUwMDJCUEVWNGNHOXVaVzUwUGtGUlFVSThMMFY0Y0c5dVpXNTBQanhRUGk5b05HTkVkMk5YUlVsa1FsRlhSVkJSWTBKWVVsbFpTa0pQWjBWWFpsQmxlRTlwVW14WmJUbG9VRGxLT0ZCRU5rZEVjVGhTTUZOaldFcFRWMGxHWlZwWk5pOXdPWEo1TlU5NWJrOU1ZbXczYUdGR1EzcDNQVDA4TDFBXHUwMDJCUEZFXHUwMDJCZUM5UE5Ga3dRVWRtZWpoT2Nrb3hObHBFV0dVemNFeG1jRTR4UVdWVE9HMUJNbEl5SzJFclduQkVkRzFpWTFsdGJtdENSbVJHZUhOUlNreEVVbUpKTTJaUVdYTXhLMnBRVlRaQk5rZzRlbU01Ym01UWVGRTlQVHd2VVQ0OFJGQVx1MDAyQmRGRjJNbkZoTkN0NGFDOVlSMmxHZDI5VlVFdzJZbWxLUkVodVVsQTVWa1I2WWpVd2JYSnROekJPYldoalNYWXZXWFYyVmpSSFF6bHNhV2N5YmxkNFRESklORzlxY1ZncmQyMTNVMlpRYXpsVVFVOU5aVkU5UFR3dlJGQVx1MDAyQlBFUlJQbkpaUVVOMVJWSm1TSFI2TUc1YWNVMUZRbHBoYWtORkx6VkZkVVF6VjA5WVFsbDVVVmhFYjA5Q1JqZDVhekJDUlZaRU9FdDRWbmhLU205TWVUVkVRWFpUT0ZKRmVIaHBhR2hxZG1KRk5uSnpPVkZhWm5wUlBUMDhMMFJSUGp4SmJuWmxjbk5sVVQ0d2JFODBjRGhZUkVWd2EwNTJZMWx6Y1dRdlpGQlRUMVJVVjJrM1VuRk5aM0ZZYmtoc1NUVnVWRzlOWmxacmVqWlVhSHBaV1c1Q1oybFBlWGxNWkRGdWNGcHdWVFJqVVhSaVREbDFSblZGYmtWSGFtcEdkejA5UEM5SmJuWmxjbk5sVVQ0OFJENTJlU3RsU1ZabGJGUkNhbEpoZUdOdGRXMWxRM3BJTTJNMVdHNTNOakZhUlVaeVpuSm9lWGxwY2sxcFkzVnhjbXBxT0d0WlUzSlFWMlV3V0RObk4wZENXV1pXVldKM1FtOVpaSGRqWW5rMWRXZHpaVWQ2T1ZaTWJtNXljbUU0Y0VneVREVTBialJSY0hONVpWUjFia3gwUzNSeFUyWklLMGt4TlVNNE9VZ3dkbTVtWTBkb1ptdHVUblI0TDNveFdYTjZWak5WUmk5NVJVaE9Wa3A0TVZSQ0wxZEhWbmc1Y1U4MVZVVTlQQzlFUGp3dlVsTkJTMlY1Vm1Gc2RXVVx1MDAyQiIsIlB1YmxpY0tleSI6IlBGSlRRVXRsZVZaaGJIVmxQanhOYjJSMWJIVnpQbmh1ZEZaaVNHOXFaMkp3WldwVmJVNXlhakJ6YmpjNVNYQnlZaTkxY25WcllqZGlValZYTkNzeVNrSllUalowUWtaMWVFZHBNWEozYkdsRFZsSmpSV3d6TjJOSlFqazNabmt4VlZkeFIzTk5iaTloZVVaQ05pOWhVRmhHTkRoa1l6QmlTbGQ0V21GUGFHbFllRXBMVTJOWFltUnFWMUJJTmxwdFRtaGtZMDB6VDNZd0szbGpVbE5aTjBSQ1lsTlRLelZ1WlZsaVFsVnZSblp0WjJKVFRuQldUbXRoWVhKbU1IbHJjejA4TDAxdlpIVnNkWE1cdTAwMkJQRVY0Y0c5dVpXNTBQa0ZSUVVJOEwwVjRjRzl1Wlc1MFBqd3ZVbE5CUzJWNVZtRnNkV1VcdTAwMkIiLCJQcml2YXRlS2V5UGVtIjoiLS0tLS1CRUdJTiBSU0EgUFJJVkFURSBLRVktLS0tLVxuTUlJQ1h3SUJBQUtCZ1FER2UxVnNlaU9CdWw2TlNZMnVQU3lmdjBpbXR2XHUwMDJCNnU2UnZ0dEhsYmo3WWtGYzNxMEVXXG43RWFMV3ZDV0lKVkZ3U1hmdHdnSDN0L0xWUmFvYXd5ZjlySVVIcjlvOWNYangxelJzbGJGbG82R0pmRWtwSnhaXG50Mk5ZOGZwbVkyRjF3emM2L1Q3SnhGSmpzTUZ0Skw3bWQ1aHNGU2dXXHUwMDJCYUJ0STJsVTJScHF0L1RLU3dJREFRQUJcbkFvR0JBTDh2bmlGWHBVd1kwV3NYSnJwbmdzeDkzT1Y1OE90V1JCYTM2NGNzb3F6SW5McXE0NC9KR0VxejFudEZcbjk0T3hnV0gxVkc4QWFHSGNIRzh1Ym9MSGhzL1ZTNTU2NjJ2S1I5aVx1MDAyQmVKXHUwMDJCRUtiTW5rN3B5N1NyYWtueC9pTmVRXG52UFI5TDUzM0JvWDVKemJjZjg5V0xNMWQxQmY4aEJ6VlNjZFV3ZjFobGNmYWp1VkJBa0VBL2g0Y0R3Y1dFSWRCXG5RV0VQUWNCWFJZWUpCT2dFV2ZQZXhPaVJsWW05aFA5SjhQRDZHRHE4UjBTY1hKU1dJRmVaWTYvcDlyeTVPeW5PXG5MYmw3aGFGQ3p3SkJBTWZ6dUdOQUJuOC9EYXlkZW1RMTN0NlMzNlRkUUhrdkpnTmtkdm12bWFRN1ptM0dKcDVBXG5SWFJjYkVDU3cwV3lOM3oyTE5mb3oxT2dPaC9NM1BaNXo4VUNRUUMxQy9hcHJqN0dIOWNhSVhDaFE4dnB1SWtNXG5lZEUvMVVQTnZuU2F1YnZRMmFGd2kvOWk2OVhnWUwyV0tEYWRiRXZZZmlpT3BmN0NiQko4XHUwMDJCVDFNQTR4NUFrRUFcbnJZQUN1RVJmSHR6MG5acU1FQlphakNFLzVFdUQzV09YQll5UVhEb09CRjd5azBCRVZEOEt4VnhKSm9MeTVEQXZcblM4UkV4eGloaGp2YkU2cnM5UVpmelFKQkFOSlR1S2ZGd3hLWkRiM0dMS25mM1QwamswMW91MGFqSUtsNXg1U09cblowNkRIMVpNXHUwMDJCazRjMkdKd1lJanNzaTNkWjZXYVZPSEVMV3kvYmhiaEp4Qm80eGM9XG4tLS0tLUVORCBSU0EgUFJJVkFURSBLRVktLS0tLSIsIlB1YmxpY0tleVBlbSI6Ii0tLS0tQkVHSU4gUFVCTElDIEtFWS0tLS0tXG5NSUdmTUEwR0NTcUdTSWIzRFFFQkFRVUFBNEdOQURDQmlRS0JnUURHZTFWc2VpT0J1bDZOU1kydVBTeWZ2MGltXG50dlx1MDAyQjZ1NlJ2dHRIbGJqN1lrRmMzcTBFVzdFYUxXdkNXSUpWRndTWGZ0d2dIM3QvTFZSYW9hd3lmOXJJVUhyOW9cbjljWGp4MXpSc2xiRmxvNkdKZkVrcEp4WnQyTlk4ZnBtWTJGMXd6YzYvVDdKeEZKanNNRnRKTDdtZDVoc0ZTZ1dcblx1MDAyQmFCdEkybFUyUnBxdC9US1N3SURBUUFCXG4tLS0tLUVORCBQVUJMSUMgS0VZLS0tLS0ifQ==";
            EmplQueryRequestModel model = new EmplQueryRequestModel();
            model.UserCode = "woodman";
            model.CorpCode = "UOFXTraining0514";

            var emp = await UofxService.BASE.OrgEmpl.GetDept(model);

            var dept = emp.Depts.FirstOrDefault();

            Console.WriteLine($"Dept Code: {dept.Code}");

            //var file = await UofxService.File.FileUpload
            //    ("D:/採購資訊.pdf");

            //var item = new FileItem() { Id = file.Id, FileName = file.FileName };

            //List<FileItem> fileList = new List<FileItem>();
            //fileList.Add(item);

            //string msg = "";

            //try
            //{
            //    string traceid = await UofxService.BPM.ApplyForm(
            //        new UofxFormSchema()
            //        {
            //            Account = "woodman",
            //            DeptCode = dept.Code,
            //            AttachFiles = fileList,
            //            Fields =
            //            { C002=DateTime.Today,
            //             C003="小黃",C004="高雄市前鎮區.."
            //             }

            //        }
            //        );

            //    msg += "\r\n" + $"It is success.";
            //    msg += "\r\n" + $"Trace Id: {traceid}";
            //}
            //catch (Exception ex)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    var errorModel = UofxService.Error.ConvertToModel(ex);
            //    msg += "\r\n" + UofxService.Json.Convert(errorModel);
            //}

            //Console.WriteLine(msg);
        }
    }
}
