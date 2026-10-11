using Microsoft.AspNetCore.Mvc;
using QRCoder;
using System.Drawing;
using System.Drawing.Imaging;

namespace SignalRWebUI.Controllers
{
    public class QRCodeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string value, IFormFile qrImage, string operation)
        {
            if(operation == "create")
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        QRCodeGenerator createQRCode = new QRCodeGenerator();
                        QRCodeGenerator.QRCode squareCode =
                            createQRCode.CreateQrCode(value, QRCodeGenerator.ECCLevel.Q);
                        using (Bitmap image = squareCode.GetGraphic(10))
                        {
                            image.Save(memoryStream, ImageFormat.Png);
                            ViewBag.QrCodeImage ="data:image/png;base64," + Convert.ToBase64String(memoryStream.ToArray());
                        }
                    }
                }
            }
            else if(operation == "decode")
            {
                if (qrImage == null || qrImage.Length == 0)
                {
                    ViewBag.Error = "Lütfen bir QR kod görseli seçin.";
                }
                else
                {
                    try
                    {
                        using (var stream = qrImage.OpenReadStream())
                        using (var bitmap = new Bitmap(stream))
                        {
                            var reader = new ZXing.Windows.Compatibility.BarcodeReader();
                            var result = reader.Decode(bitmap);
                            if (result != null)
                                ViewBag.DecodedValue = result.Text;
                            else
                                ViewBag.Error = "Görselde QR kod bulunamadı.";
                        }
                    }
                    catch
                    {
                        ViewBag.Error = "Görsel okunamadı. Lütfen geçerli bir resim seçin.";
                    }
                }
            }
            return View();
        }
    }
}
