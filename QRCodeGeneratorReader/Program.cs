using System.Drawing;
using ZXing.QrCode;
using ZXing;
using ZXing.Common;
using ZXing.Windows.Compatibility;
using System.Text;
using System.Net.NetworkInformation;

string imageFileName = "klc_qr_code.png";

QrCodeEncodingOptions options = new()
{
    DisableECI = true,
    CharacterSet = "UTF-8",
    Width = 500,
    Height = 500
};

ZXing.Windows.Compatibility.BarcodeWriter writer = new()
{
    Format = BarcodeFormat.QR_CODE,
    Options = options
};



var contactInfo = new StringBuilder();
contactInfo.Append("bosak peder:");
contactInfo.Append("pokemoni");


Bitmap qrCodeBitmap = writer.Write(contactInfo.ToString());
qrCodeBitmap.Save(imageFileName);





DecodingOptions readOptions = new()
{
    PossibleFormats = new List<BarcodeFormat> { BarcodeFormat.QR_CODE },
    TryHarder = true
};

Bitmap readQRCodeBitmap = new(imageFileName);
BarcodeReader reader = new()
{
    Options = readOptions
};
Result qrCodeResult = reader.Decode(readQRCodeBitmap);

if (qrCodeResult != null)
    Console.WriteLine(qrCodeResult.Text);