using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TheArtOfDev.HtmlRenderer.WinForms;

namespace Turev
{

    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            htmlLabel1.Text = @"<div style='text-align:center;padding:15%;font-weight: bold;font-size:20px;'>Sonuç Bölümü</div>";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public class HtmlPoweredLabel : Control
        {
            protected override void OnPaint(PaintEventArgs e)
            {
                string html = string.Format(System.Globalization.CultureInfo.InvariantCulture,
                    "<div style=\"font-family:{0}; font-size:{1}pt;\">{2}</div>",
                    this.Font.FontFamily.Name,
                    this.Font.SizeInPoints,
                    this.Text);

                var topLeftCorner = new System.Drawing.PointF(0, 0);
                var size = this.Size;

                HtmlRender.Render(e.Graphics, html, topLeftCorner, size);

                base.OnPaint(e);
            }
        }

        private int _terimsayisi1,
            _terimsayisi2,
            _terimsayisi3,
            _terimsayisi4,
            _terimsayisi5,
            _ussayisi1,
            _ussayisi2,
            _ussayisi3,
            _ussayisi4,
            _ussayisi5,
            _birinciTerimIslem,
            _ikinciTerimIslem,
            _ucuncuTerimIslem,
            _dorduncuTerimIslem,
            _besinciTerimIslem,
            _azalmamisus1,
            _azalmamisus2,
            _azalmamisus3,
            _azalmamisus4,
            _azalmamisus5;
        private string _islem1,
        _islem2,
        _islem3,
        _islem4,
        _sonucislem1,
        _sonucislem2,
        _sonucislem3,
        _sonucislem4,
        _genelsonuc,
        _xdegiskeni1,
        _xdegiskeni2,
        _xdegiskeni3,
        _xdegiskeni4,
        _xdegiskeni5,
            _p1, _p2, _p3, _p4, _p5, _u1, _u2, _u3, _u4, _u5;
        private void button1_Click(object sender, EventArgs e)
        {


            try
            {

                // GİRİLEN DEĞERLER BOŞ MU?
                if (birinciIslem.EditValue == null
                    || ikinciIslem.EditValue == null
                    || ucuncuIslem.EditValue == null
                    || dorduncuIslem.EditValue == null
                    || birinciIslem.SelectedIndex == -1
                    || ikinciIslem.SelectedIndex == -1
                    || ucuncuIslem.SelectedIndex == -1
                    || dorduncuIslem.SelectedIndex == -1
                    || birinciTerim.Text == ""
                    || ikinciTerim.Text == ""
                    || ucuncuTerim.Text == ""
                    || dorduncuTerim.Text == ""
                    || besinciTerim.Text == ""
                    || altinciTerim.Text == ""
                    || birinciUs.Text == ""
                    || ikinciUs.Text == ""
                    || ucuncuUs.Text == ""
                    || dorduncuUs.Text == ""
                    || besinciUs.Text == ""
                    || birinciIslem.Text == ""
                    || ikinciIslem.Text == ""
                    || ucuncuIslem.Text == ""
                    || dorduncuIslem.Text == ""

                )
                {
                    XtraMessageBox.Show("Tüm Alanları Doldurduğunuzdan Emin Olup Tekrar Deneyin.", "Hata");
                }
                // GİRİLEN DEĞERLER BOŞ MU? Bitiş
                else
                {


                    // GİRİLEN TERİMLER SİN İÇERİYORSA

                    string sarr1 = birinciTerim.Text.Contains("sin") && birinciTerim.Text.Contains("x")
                        ? birinciTerim.Text.Split(new[] { "sin", "x" }, StringSplitOptions.None)[1]
                        : "";
                    string sarr2 = ikinciTerim.Text.Contains("sin") && ikinciTerim.Text.Contains("x")
                        ? ikinciTerim.Text.Split(new[] { "sin", "x" }, StringSplitOptions.None)[1]
                        : "";
                    string sarr3 = ucuncuTerim.Text.Contains("sin") && ucuncuTerim.Text.Contains("x")
                        ? ucuncuTerim.Text.Split(new[] { "sin", "x" }, StringSplitOptions.None)[1]
                        : "";
                    string sarr4 = dorduncuTerim.Text.Contains("sin") && dorduncuTerim.Text.Contains("x")
                        ? dorduncuTerim.Text.Split(new[] { "sin", "x" }, StringSplitOptions.None)[1]
                        : "";
                    string sarr5 = besinciTerim.Text.Contains("sin") && besinciTerim.Text.Contains("x")
                        ? besinciTerim.Text.Split(new[] { "sin", "x" }, StringSplitOptions.None)[1]
                        : "";

                    // GİRİLEN TERİMLER SİN İÇERİYORSA Bitiş

                    // GİRİLEN TERİMLER COS İÇERİYORSA

                    string carr1 = birinciTerim.Text.Contains("cos") && birinciTerim.Text.Contains("x")
                        ? birinciTerim.Text.Split(new[] { "cos", "x" }, StringSplitOptions.None)[1]
                        : "";
                    string carr2 = ikinciTerim.Text.Contains("cos") && ikinciTerim.Text.Contains("x")
                        ? ikinciTerim.Text.Split(new[] { "cos", "x" }, StringSplitOptions.None)[1]
                        : "";
                    string carr3 = ucuncuTerim.Text.Contains("cos") && ucuncuTerim.Text.Contains("x")
                        ? ucuncuTerim.Text.Split(new[] { "cos", "x" }, StringSplitOptions.None)[1]
                        : "";
                    string carr4 = dorduncuTerim.Text.Contains("cos") && dorduncuTerim.Text.Contains("x")
                        ? dorduncuTerim.Text.Split(new[] { "cos", "x" }, StringSplitOptions.None)[1]
                        : "";
                    string carr5 = besinciTerim.Text.Contains("cos") && besinciTerim.Text.Contains("x")
                        ? besinciTerim.Text.Split(new[] { "cos", "x" }, StringSplitOptions.None)[1]
                        : "";

                    // GİRİLEN TERİMLER COS İÇERİYORSA

                    // GİRİLEN TERİMLERİN SADECE SAYI VEYA BİR BİLİNMEYENLİ OLUP OLMADIĞININ KONTROLÜ 

                    string arr1 =
                        !birinciTerim.Text.Contains("sin") && !birinciTerim.Text.Contains("cos") &&
                        birinciTerim.Text.Contains("x")
                            ?
                            birinciTerim.Text.Split(new[] { "x" }, StringSplitOptions.None)[0]
                            : !birinciTerim.Text.Contains("x")
                                ? birinciTerim.Text
                                : "";
                    string arr2 =
                        !ikinciTerim.Text.Contains("sin") && !ikinciTerim.Text.Contains("cos") &&
                        ikinciTerim.Text.Contains("x")
                            ?
                            ikinciTerim.Text.Split(new[] { "x" }, StringSplitOptions.None)[0]
                            : !ikinciTerim.Text.Contains("x")
                                ? ikinciTerim.Text
                                : "";
                    string arr3 =
                        !ucuncuTerim.Text.Contains("sin") && !ucuncuTerim.Text.Contains("cos") &&
                        ucuncuTerim.Text.Contains("x")
                            ?
                            ucuncuTerim.Text.Split(new[] { "x" }, StringSplitOptions.None)[0]
                            : !ucuncuTerim.Text.Contains("x")
                                ? ucuncuTerim.Text
                                : "";
                    string arr4 =
                        !dorduncuTerim.Text.Contains("sin") && !dorduncuTerim.Text.Contains("cos") &&
                        dorduncuTerim.Text.Contains("x")
                            ?
                            dorduncuTerim.Text.Split(new[] { "x" }, StringSplitOptions.None)[0]
                            : !dorduncuTerim.Text.Contains("x")
                                ? dorduncuTerim.Text
                                : "";
                    string arr5 =
                        !besinciTerim.Text.Contains("sin") && !besinciTerim.Text.Contains("cos") &&
                        besinciTerim.Text.Contains("x")
                            ?
                            besinciTerim.Text.Split(new[] { "x" }, StringSplitOptions.None)[0]
                            : !besinciTerim.Text.Contains("x")
                                ? besinciTerim.Text
                                : "";
                    if (arr1.Contains("sin") || arr2.Contains("sin") || arr3.Contains("sin") || arr4.Contains("sin") ||
                        arr5.Contains("sin") || arr1.Contains("cos") || arr2.Contains("cos") || arr3.Contains("cos") ||
                        arr4.Contains("cos") || arr5.Contains("cos"))
                    {
                        arr1 = "";
                        arr2 = "";
                        arr3 = "";
                        arr4 = "";
                        arr5 = "";
                    }

                    // GİRİLEN TERİMLERİN SADECE SAYI VEYA BİR BİLİNMEYENLİ OLUP OLMADIĞININ KONTROLÜ Bitiş

                    // Terim Sin İçeriyorsa

                    if (birinciTerim.Text.Contains("sin") && birinciTerim.Text.Contains("x") && sarr1 != "")
                    {
                        _terimsayisi1 = Convert.ToInt32(sarr1);
                        _xdegiskeni1 = "x";
                    }

                    if (ikinciTerim.Text.Contains("sin") && ikinciTerim.Text.Contains("x") && sarr2 != "")
                    {
                        _terimsayisi2 = Convert.ToInt32(sarr2);
                        _xdegiskeni2 = "x";
                    }

                    if (ucuncuTerim.Text.Contains("sin") && ucuncuTerim.Text.Contains("x") && sarr3 != "")
                    {
                        _terimsayisi3 = Convert.ToInt32(sarr3);
                        _xdegiskeni3 = "x";
                    }

                    if (dorduncuTerim.Text.Contains("sin") && dorduncuTerim.Text.Contains("x") && sarr4 != "")
                    {
                        _terimsayisi4 = Convert.ToInt32(sarr4);
                        _xdegiskeni4 = "x";
                    }

                    if (besinciTerim.Text.Contains("sin") && besinciTerim.Text.Contains("x") && sarr5 != "")
                    {
                        _terimsayisi5 = Convert.ToInt32(sarr5);
                        _xdegiskeni5 = "x";
                    }

                    // Terim Sin İçeriyorsa Bitiş

                    // Terim Cos İçeriyorsa

                    if (birinciTerim.Text.Contains("cos") && birinciTerim.Text.Contains("x") && carr1 != "")
                    {
                        _terimsayisi1 = Convert.ToInt32(carr1);
                        _xdegiskeni1 = "x";
                    }

                    if (ikinciTerim.Text.Contains("cos") && ikinciTerim.Text.Contains("x") && carr2 != "")
                    {
                        _terimsayisi2 = Convert.ToInt32(carr2);
                        _xdegiskeni2 = "x";
                    }

                    if (ucuncuTerim.Text.Contains("cos") && ucuncuTerim.Text.Contains("x") && carr3 != "")
                    {
                        _terimsayisi3 = Convert.ToInt32(carr3);
                        _xdegiskeni3 = "x";
                    }

                    if (dorduncuTerim.Text.Contains("cos") && dorduncuTerim.Text.Contains("x") && carr4 != "")
                    {
                        _terimsayisi4 = Convert.ToInt32(carr4);
                        _xdegiskeni4 = "x";
                    }

                    if (besinciTerim.Text.Contains("cos") && besinciTerim.Text.Contains("x") && carr5 != "")
                    {
                        _terimsayisi5 = Convert.ToInt32(carr5);
                        _xdegiskeni5 = "x";
                    }

                    // Terim Cos İçeriyorsa Bitiş

                    // Terim Sayısı Belirleme İşlemi Sin ve Cos Yoksa 

                    if (!arr1.Contains("sin") && !arr1.Contains("cos") && birinciTerim.Text.Contains("x") && arr1 != "")
                    {
                        _terimsayisi1 = Convert.ToInt32(arr1);
                        _xdegiskeni1 = "x";
                    }
                    else if (!birinciTerim.Text.Contains("x") && arr1 != "")
                    {
                        _terimsayisi1 = Convert.ToInt32(arr1);
                        _xdegiskeni1 = "";
                    }

                    if (!arr2.Contains("sin") && !arr2.Contains("cos") && ikinciTerim.Text.Contains("x") && arr2 != "")
                    {
                        _terimsayisi2 = Convert.ToInt32(arr2);
                        _xdegiskeni2 = "x";
                    }
                    else if (!ikinciTerim.Text.Contains("x") && arr2 != "")
                    {
                        _terimsayisi2 = Convert.ToInt32(arr2);
                        _xdegiskeni2 = "";
                    }

                    if (!arr3.Contains("sin") && !arr3.Contains("cos") && ucuncuTerim.Text.Contains("x") && arr3 != "")
                    {
                        _terimsayisi3 = Convert.ToInt32(arr3);
                        _xdegiskeni3 = "x";
                    }
                    else if (!ucuncuTerim.Text.Contains("x") && arr3 != "")
                    {
                        _terimsayisi3 = Convert.ToInt32(arr3);
                        _xdegiskeni3 = "";
                    }

                    if (!arr4.Contains("sin") && !arr4.Contains("cos") && dorduncuTerim.Text.Contains("x") &&
                        arr4 != "")
                    {
                        _terimsayisi4 = Convert.ToInt32(arr4);
                        _xdegiskeni4 = "x";
                    }
                    else if (!dorduncuTerim.Text.Contains("x") && arr4 != "")
                    {
                        _terimsayisi4 = Convert.ToInt32(arr4);
                        _xdegiskeni4 = "";
                    }

                    if (!arr5.Contains("sin") && !arr5.Contains("cos") && besinciTerim.Text.Contains("x") && arr5 != "")
                    {
                        _terimsayisi5 = Convert.ToInt32(arr5);
                        _xdegiskeni5 = "x";
                    }
                    else if (!besinciTerim.Text.Contains("x") && arr5 != "")
                    {
                        _terimsayisi5 = Convert.ToInt32(arr5);
                        _xdegiskeni5 = "";
                    }

                    // Terim Sayısı Belirleme İşlemi Sin ve Cos Yoksa Bitiş

                    // GİRİLEN TERİMLERİN SADECE SAYI VEYA BİR BİLİNMEYENLİ OLUP OLMADIĞININ KONTROLÜ BİTİŞ




                    // Üs Sayısını Al

                    _ussayisi1 = Convert.ToInt32(birinciUs.Text);
                    _ussayisi2 = Convert.ToInt32(ikinciUs.Text);
                    _ussayisi3 = Convert.ToInt32(ucuncuUs.Text);
                    _ussayisi4 = Convert.ToInt32(dorduncuUs.Text);
                    _ussayisi5 = Convert.ToInt32(besinciUs.Text);

                    // Üs Sayısını Al Bitiş




                    // Üs Sayısı - Girilmişse Bile İşlemde + Halini Almak İçin Kendisiyle Çarp Değilse Zaten Kendisini Yaz

                    if (arr1 != "")
                    {
                        _birinciTerimIslem =
                            Convert.ToInt32(_terimsayisi1 * (_ussayisi1 < 0 ? _ussayisi1 * -1 : _ussayisi1));
                    }

                    if (arr2 != "")
                    {
                        _ikinciTerimIslem =
                            Convert.ToInt32(_terimsayisi2 * (_ussayisi2 < 0 ? _ussayisi2 * -1 : _ussayisi2));
                    }

                    if (arr3 != "")
                    {
                        _ucuncuTerimIslem =
                            Convert.ToInt32(_terimsayisi3 * (_ussayisi3 < 0 ? _ussayisi3 * -1 : _ussayisi3));
                    }

                    if (arr4 != "")
                    {
                        _dorduncuTerimIslem =
                            Convert.ToInt32(_terimsayisi4 * (_ussayisi4 < 0 ? _ussayisi4 * -1 : _ussayisi4));
                    }

                    if (arr5 != "")
                    {
                        _besinciTerimIslem =
                            Convert.ToInt32(_terimsayisi5 * (_ussayisi5 < 0 ? _ussayisi5 * -1 : _ussayisi5));
                    }

                    // Üs Sayısı - Girilmişse Bile İşlemde + Halini Almak İçin Kendisiyle Çarp Değilse Zaten Kendisini Yaz




                    // Üs Sayısı - Girilmişse Bile İşlemde + Halini Almak İçin Kendisiyle Çarp Değilse Zaten Kendisini Yaz Sin
                    if (sarr1 != "")
                    {
                        _birinciTerimIslem =
                            Convert.ToInt32(_terimsayisi1 * (_ussayisi1 < 0 ? _ussayisi1 * -1 : _ussayisi1));
                    }

                    if (sarr2 != "")
                    {
                        _ikinciTerimIslem =
                            Convert.ToInt32(_terimsayisi2 * (_ussayisi2 < 0 ? _ussayisi2 * -1 : _ussayisi2));
                    }

                    if (sarr3 != "")
                    {
                        _ucuncuTerimIslem =
                            Convert.ToInt32(_terimsayisi3 * (_ussayisi3 < 0 ? _ussayisi3 * -1 : _ussayisi3));
                    }

                    if (sarr4 != "")
                    {
                        _dorduncuTerimIslem =
                            Convert.ToInt32(_terimsayisi4 * (_ussayisi4 < 0 ? _ussayisi4 * -1 : _ussayisi4));
                    }

                    if (sarr5 != "")
                    {
                        _besinciTerimIslem =
                            Convert.ToInt32(_terimsayisi5 * (_ussayisi5 < 0 ? _ussayisi5 * -1 : _ussayisi5));
                    }
                    // Üs Sayısı - Girilmişse Bile İşlemde + Halini Almak İçin Kendisiyle Çarp Değilse Zaten Kendisini Yaz Sin Bitiş




                    // Üs Sayısı - Girilmişse Bile İşlemde + Halini Almak İçin Kendisiyle Çarp Değilse Zaten Kendisini Yaz Cos
                    if (carr1 != "")
                    {
                        _birinciTerimIslem =
                            Convert.ToInt32(_terimsayisi1 * (_ussayisi1 < 0 ? _ussayisi1 * -1 : _ussayisi1));
                    }

                    if (carr2 != "")
                    {
                        _ikinciTerimIslem =
                            Convert.ToInt32(_terimsayisi2 * (_ussayisi2 < 0 ? _ussayisi2 * -1 : _ussayisi2));
                    }

                    if (carr3 != "")
                    {
                        _ucuncuTerimIslem =
                            Convert.ToInt32(_terimsayisi3 * (_ussayisi3 < 0 ? _ussayisi3 * -1 : _ussayisi3));
                    }

                    if (carr4 != "")
                    {
                        _dorduncuTerimIslem =
                            Convert.ToInt32(_terimsayisi4 * (_ussayisi4 < 0 ? _ussayisi4 * -1 : _ussayisi4));
                    }

                    if (carr5 != "")
                    {
                        _besinciTerimIslem =
                            Convert.ToInt32(_terimsayisi5 * (_ussayisi5 < 0 ? _ussayisi5 * -1 : _ussayisi5));
                    }
                    // Üs Sayısı - Girilmişse Bile İşlemde + Halini Almak İçin Kendisiyle Çarp Değilse Zaten Kendisini Yaz Cos Bitiş




                    // Terim x Girildiyse Terim İşlemini Yap

                    if (birinciTerim.Text.Equals("x"))
                    {
                        _terimsayisi1 = 1;
                        _birinciTerimIslem =
                            Convert.ToInt32(_terimsayisi1 * (_ussayisi1 < 0 ? _ussayisi1 * -1 : _ussayisi1));
                        _xdegiskeni1 = "x";
                    }

                    if (ikinciTerim.Text.Equals("x"))
                    {
                        _terimsayisi2 = 1;
                        _ikinciTerimIslem =
                            Convert.ToInt32(_terimsayisi2 * (_ussayisi2 < 0 ? _ussayisi2 * -1 : _ussayisi2));
                        _xdegiskeni2 = "x";
                    }

                    if (ucuncuTerim.Text.Equals("x"))
                    {
                        _terimsayisi3 = 1;
                        _ucuncuTerimIslem =
                            Convert.ToInt32(_terimsayisi3 * (_ussayisi3 < 0 ? _ussayisi3 * -1 : _ussayisi3));
                        _xdegiskeni3 = "x";
                    }

                    if (dorduncuTerim.Text.Equals("x"))
                    {
                        _terimsayisi4 = 1;
                        _dorduncuTerimIslem =
                            Convert.ToInt32(_terimsayisi4 * (_ussayisi4 < 0 ? _ussayisi4 * -1 : _ussayisi4));
                        _xdegiskeni4 = "x";
                    }

                    if (besinciTerim.Text.Equals("x"))
                    {
                        _terimsayisi5 = 1;
                        _besinciTerimIslem =
                            Convert.ToInt32(_terimsayisi5 * (_ussayisi5 < 0 ? _ussayisi5 * -1 : _ussayisi5));
                        _xdegiskeni5 = "x";
                    }
                    // Terim x Girildiyse Terim İşlemini Yap Bitiş




                    // Terim sinx Girildiyse Terim İşlemini Yap

                    if (birinciTerim.Text.Equals("sinx"))
                    {
                        _terimsayisi1 = 1;
                        _birinciTerimIslem =
                            Convert.ToInt32(_terimsayisi1 * (_ussayisi1 < 0 ? _ussayisi1 * -1 : _ussayisi1));
                        _xdegiskeni1 = "x";
                    }

                    if (ikinciTerim.Text.Equals("sinx"))
                    {
                        _terimsayisi2 = 1;
                        _ikinciTerimIslem =
                            Convert.ToInt32(_terimsayisi2 * (_ussayisi2 < 0 ? _ussayisi2 * -1 : _ussayisi2));
                        _xdegiskeni2 = "x";
                    }

                    if (ucuncuTerim.Text.Equals("sinx"))
                    {
                        _terimsayisi3 = 1;
                        _ucuncuTerimIslem =
                            Convert.ToInt32(_terimsayisi3 * (_ussayisi3 < 0 ? _ussayisi3 * -1 : _ussayisi3));
                        _xdegiskeni3 = "x";
                    }

                    if (dorduncuTerim.Text.Equals("sinx"))
                    {
                        _terimsayisi4 = 1;
                        _dorduncuTerimIslem =
                            Convert.ToInt32(_terimsayisi4 * (_ussayisi4 < 0 ? _ussayisi4 * -1 : _ussayisi4));
                        _xdegiskeni4 = "x";
                    }

                    if (besinciTerim.Text.Equals("sinx"))
                    {
                        _terimsayisi5 = 1;
                        _besinciTerimIslem =
                            Convert.ToInt32(_terimsayisi5 * (_ussayisi5 < 0 ? _ussayisi5 * -1 : _ussayisi5));
                        _xdegiskeni5 = "x";
                    }
                    // Terim sinx Girildiyse Terim İşlemini Yap Bitiş



                    // Terim cosx Girildiyse Terim İşlemini Yap

                    if (birinciTerim.Text.Equals("cosx"))
                    {
                        _terimsayisi1 = 1;
                        _birinciTerimIslem =
                            Convert.ToInt32(_terimsayisi1 * (_ussayisi1 < 0 ? _ussayisi1 * -1 : _ussayisi1));
                        _xdegiskeni1 = "x";
                    }

                    if (ikinciTerim.Text.Equals("cosx"))
                    {
                        _terimsayisi2 = 1;
                        _ikinciTerimIslem =
                            Convert.ToInt32(_terimsayisi2 * (_ussayisi2 < 0 ? _ussayisi2 * -1 : _ussayisi2));
                        _xdegiskeni2 = "x";
                    }

                    if (ucuncuTerim.Text.Equals("cosx"))
                    {
                        _terimsayisi3 = 1;
                        _ucuncuTerimIslem =
                            Convert.ToInt32(_terimsayisi3 * (_ussayisi3 < 0 ? _ussayisi3 * -1 : _ussayisi3));
                        _xdegiskeni3 = "x";
                    }

                    if (dorduncuTerim.Text.Equals("cosx"))
                    {
                        _terimsayisi4 = 1;
                        _dorduncuTerimIslem =
                            Convert.ToInt32(_terimsayisi4 * (_ussayisi4 < 0 ? _ussayisi4 * -1 : _ussayisi4));
                        _xdegiskeni4 = "x";
                    }

                    if (besinciTerim.Text.Equals("cosx"))
                    {
                        _terimsayisi5 = 1;
                        _besinciTerimIslem =
                            Convert.ToInt32(_terimsayisi5 * (_ussayisi5 < 0 ? _ussayisi5 * -1 : _ussayisi5));
                        _xdegiskeni5 = "x";
                    }

                    // Terim cosx Girildiyse Terim İşlemini Yap Bitiş




                    // Üssü Azaltmadan Önce Sin ve Cos İçin Hafızada Tut

                    _azalmamisus1 = _ussayisi1;
                    _azalmamisus2 = _ussayisi2;
                    _azalmamisus3 = _ussayisi3;
                    _azalmamisus4 = _ussayisi4;
                    _azalmamisus5 = _ussayisi5;

                    // Üssü Azaltmadan Önce Sin ve Cos İçin Hafızada Tut Bitiş




                    // Terim İşlemi Yapıldıysa Üssü 1 Azalt

                    _ussayisi1--;
                    _ussayisi2--;
                    _ussayisi3--;
                    _ussayisi4--;
                    _ussayisi5--;

                    // Terim İşlemi Yapıldıysa Üssü 1 Azalt Bitiş




                    // İşlemleri Al

                    _islem1 = birinciIslem.Text;
                    _islem2 = ikinciIslem.Text;
                    _islem3 = ucuncuIslem.Text;
                    _islem4 = dorduncuIslem.Text;

                    // İşlemleri Al Bitiş




                    // Üs Sayısı 0'dan Küçükse İşlemi Değiştir Değilse Aynen Yaz 

                    if (_ussayisi2 < 0 && _islem1 == "+")
                    {
                        _sonucislem1 = "-";
                    }
                    else if (_ussayisi2 < 0 && _islem1 == "-")
                    {
                        _sonucislem1 = "+";
                    }
                    else
                    {
                        _sonucislem1 = _islem1;
                    }

                    if (_ussayisi3 < 0 && _islem2 == "+")
                    {
                        _sonucislem2 = "-";
                    }
                    else if (_ussayisi3 < 0 && _islem2 == "-")
                    {
                        _sonucislem2 = "+";
                    }
                    else
                    {
                        _sonucislem2 = _islem2;
                    }

                    if (_ussayisi4 < 0 && _islem3 == "+")
                    {
                        _sonucislem3 = "-";
                    }
                    else if (_ussayisi4 < 0 && _islem3 == "-")
                    {
                        _sonucislem3 = "+";
                    }
                    else
                    {
                        _sonucislem3 = _islem3;
                    }

                    if (_ussayisi5 < 0 && _islem4 == "+")
                    {
                        _sonucislem4 = "-";
                    }
                    else if (_ussayisi5 < 0 && _islem4 == "-")
                    {
                        _sonucislem4 = "+";
                    }
                    else
                    {
                        _sonucislem4 = _islem4;
                    }

                    // Üs Sayısı 0'dan Küçükse İşlemi Değiştir Değilse Aynen Yaz 




                    // Terim 0 Girildiyse Üs 0 İse 0^0=1 Olacağından Terim İşlemini Sabit Belirliyoruz Girilen Terim 0 İse Üs 0'dan Farklı İse İşlem Her Zaman 0'dır.

                    if (birinciTerim.Text.Equals("0") && _ussayisi1 == 0)
                    {
                        _birinciTerimIslem = 1;
                        _xdegiskeni1 = "";
                    }
                    else if (birinciTerim.Text.Equals("0") && _ussayisi1 > 0)
                    {
                        _birinciTerimIslem = 0;
                        _xdegiskeni1 = "";
                    }

                    if (ikinciTerim.Text.Equals("0") && _ussayisi2 == 0)
                    {
                        _ikinciTerimIslem = 1;
                        _xdegiskeni2 = "";
                    }
                    else if (ikinciTerim.Text.Equals("0") && _ussayisi2 > 0)
                    {
                        _ikinciTerimIslem = 0;
                        _xdegiskeni2 = "";
                    }

                    if (ucuncuTerim.Text.Equals("0") && _ussayisi3 == 0)
                    {
                        _ucuncuTerimIslem = 1;
                        _xdegiskeni3 = "";
                    }
                    else if (ucuncuTerim.Text.Equals("0") && _ussayisi3 > 0)
                    {
                        _ucuncuTerimIslem = 0;
                        _xdegiskeni3 = "";
                    }

                    if (dorduncuTerim.Text.Equals("0") && _ussayisi4 == 0)
                    {
                        _dorduncuTerimIslem = 1;
                        _xdegiskeni4 = "";
                    }
                    else if (dorduncuTerim.Text.Equals("0") && _ussayisi4 > 0)
                    {
                        _dorduncuTerimIslem = 0;
                        _xdegiskeni4 = "";
                    }

                    if (besinciTerim.Text.Equals("0") && _ussayisi5 == 0)
                    {
                        _besinciTerimIslem = 1;
                        _xdegiskeni5 = "";
                    }
                    else if (besinciTerim.Text.Equals("0") && _ussayisi5 > 0)
                    {
                        _besinciTerimIslem = 0;
                        _xdegiskeni5 = "";
                    }

                    // Terim 0 Girildiyse Üs 0 İse 0^0=1 Olacağından Terim İşlemini Sabit Belirliyoruz Girilen Terim 0 İse Üs 0'dan Farklı İse İşlem Her Zaman 0'dır. Bitiş




                    // Terim 0x Girildiyse Terim İşlemini 0'a Eşitle

                    if (birinciTerim.Text.Equals("0x"))
                    {
                        _birinciTerimIslem = 0;
                        _xdegiskeni1 = "";
                    }

                    if (ikinciTerim.Text.Equals("0x"))
                    {
                        _ikinciTerimIslem = 0;
                        _xdegiskeni2 = "";
                    }

                    if (ucuncuTerim.Text.Equals("0x"))
                    {
                        _ucuncuTerimIslem = 0;
                        _xdegiskeni3 = "";
                    }

                    if (dorduncuTerim.Text.Equals("0x"))
                    {
                        _dorduncuTerimIslem = 0;
                        _xdegiskeni4 = "";
                    }

                    if (besinciTerim.Text.Equals("0x"))
                    {
                        _besinciTerimIslem = 0;
                        _xdegiskeni5 = "";
                    }

                    // Terim 0x Girildiyse Terim İşlemini 0'a Eşitle Bitiş




                    // Bütün Sonucu Ekrana Bas

                    _p1 = _birinciTerimIslem == 0
                        ? birinciTerim.Text.Equals("x") ? "" : _birinciTerimIslem.ToString()
                        : _birinciTerimIslem.ToString();
                    _p2 = _ikinciTerimIslem == 0
                        ? ikinciTerim.Text.Equals("x") ? "" : _ikinciTerimIslem.ToString()
                        : _ikinciTerimIslem.ToString();
                    _p3 = _ucuncuTerimIslem == 0
                        ? ucuncuTerim.Text.Equals("x") ? "" : _ucuncuTerimIslem.ToString()
                        : _ucuncuTerimIslem.ToString();
                    _p4 = _dorduncuTerimIslem == 0
                        ? dorduncuTerim.Text.Equals("x") ? "" : _dorduncuTerimIslem.ToString()
                        : _dorduncuTerimIslem.ToString();
                    _p5 = _besinciTerimIslem == 0
                        ? besinciTerim.Text.Equals("x") ? "" : _besinciTerimIslem.ToString()
                        : _besinciTerimIslem.ToString();

                    _u1 = _p1.Equals("0")
                        ? ""
                        :
                        _ussayisi1 == 1
                            ? _xdegiskeni1
                            :
                            _ussayisi1 == 0
                                ? ""
                                :
                                birinciTerim.Text.Contains("sin")
                                    ?
                                    _xdegiskeni1 + "<sup>" + _ussayisi1 + "</sup>" + ".cos" + _xdegiskeni1 + "<sup>" +
                                    _azalmamisus1 + "</sup>"
                                    : birinciTerim.Text.Contains("cos")
                                        ? _xdegiskeni1 + "<sup>" + _ussayisi1 + "</sup>" + ".sin" + _xdegiskeni1 +
                                          "<sup>" +
                                          _azalmamisus1 + "</sup>"
                                        : _xdegiskeni1 + "<sup>" + _ussayisi1 + "</sup>";
                    _u2 = _p2.Equals("0")
                        ? ""
                        :
                        _ussayisi2 == 1
                            ? _xdegiskeni2
                            :
                            _ussayisi2 == 0
                                ? ""
                                :
                                ikinciTerim.Text.Contains("sin")
                                    ?
                                    _xdegiskeni2 + "<sup>" + _ussayisi2 + "</sup>" + ".cos" + _xdegiskeni2 + "<sup>" +
                                    _azalmamisus2 + "</sup>"
                                    : ikinciTerim.Text.Contains("cos")
                                        ? _xdegiskeni2 + "<sup>" + _ussayisi2 + "</sup>" + ".sin" + _xdegiskeni2 +
                                          "<sup>" +
                                          _azalmamisus2 + "</sup>"
                                        : _xdegiskeni2 + "<sup>" + _ussayisi2 + "</sup>";
                    _u3 = _p3.Equals("0")
                        ? ""
                        :
                        _ussayisi3 == 1
                            ? _xdegiskeni3
                            :
                            _ussayisi3 == 0
                                ? ""
                                :
                                ucuncuTerim.Text.Contains("sin")
                                    ?
                                    _xdegiskeni3 + "<sup>" + _ussayisi3 + "</sup>" + ".cos" + _xdegiskeni3 + "<sup>" +
                                    _azalmamisus3 + "</sup>"
                                    : ucuncuTerim.Text.Contains("cos")
                                        ? _xdegiskeni3 + "<sup>" + _ussayisi3 + "</sup>" + ".sin" + _xdegiskeni3 +
                                          "<sup>" +
                                          _azalmamisus3 + "</sup>"
                                        : _xdegiskeni3 + "<sup>" + _ussayisi3 + "</sup>";
                    _u4 = _p4.Equals("0")
                        ? ""
                        :
                        _ussayisi4 == 1
                            ? _xdegiskeni4
                            :
                            _ussayisi4 == 0
                                ? ""
                                :
                                dorduncuTerim.Text.Contains("sin")
                                    ?
                                    _xdegiskeni4 + "<sup>" + _ussayisi4 + "</sup>" + ".cos" + _xdegiskeni4 + "<sup>" +
                                    _azalmamisus4 + "</sup>"
                                    : dorduncuTerim.Text.Contains("cos")
                                        ? _xdegiskeni4 + "<sup>" + _ussayisi4 + "</sup>" + ".sin" + _xdegiskeni4 +
                                          "<sup>" +
                                          _azalmamisus4 + "</sup>"
                                        : _xdegiskeni4 + "<sup>" + _ussayisi4 + "</sup>";
                    _u5 = _p5.Equals("0")
                        ? ""
                        :
                        _ussayisi5 == 1
                            ? _xdegiskeni5
                            :
                            _ussayisi5 == 0
                                ? ""
                                :
                                besinciTerim.Text.Contains("sin")
                                    ?
                                    _xdegiskeni5 + "<sup>" + _ussayisi5 + "</sup>" + ".cos" + _xdegiskeni5 + "<sup>" +
                                    _azalmamisus5 + "</sup>"
                                    : besinciTerim.Text.Contains("cos")
                                        ? _xdegiskeni5 + "<sup>" + _ussayisi5 + "</sup>" + ".sin" + _xdegiskeni5 +
                                          "<sup>" +
                                          _azalmamisus5 + "</sup>"
                                        : _xdegiskeni5 + "<sup>" + _ussayisi5 + "</sup>";

                    _genelsonuc = _p1 == "0" && _p2 == "0" && _p3 == "0" && _p4 == "0" && _p5 == "0" && (_ussayisi1 < 0 || _ussayisi2 < 0 || _ussayisi3 < 0 || _ussayisi4 < 0 || _ussayisi5 < 0) ? "<div style='text-align:center;padding:15%;font-weight: bold;font-size:20px;'>Tanımsız</div>" : _p1 =="0" && _p2=="0" && _p3=="0" && _p4=="0" && _p5=="0" && (_ussayisi1!=0 || _ussayisi2!=0 || _ussayisi3!=0 || _ussayisi4!=0 || _ussayisi5!=0) ? "<div style='text-align:center;padding:15%;font-weight: bold;font-size:20px;'>0</div>" : "<div style='text-align:center;padding:15%;font-weight: bold;font-size:20px;'>" +
                                  _p1 + _u1 + _sonucislem1 +
                                  _p2 + _u2 + _sonucislem2 +
                                  _p3 + _u3 + _sonucislem3 +
                                  _p4 + _u4 + _sonucislem4 +
                                  _p5 + _u5 + "</div>";
                    htmlLabel1.Text = _genelsonuc;

                    // Bütün Sonucu Ekrana Bas




                    // Terim veya Üs Üzerinde Değişiklik Yapıldıysa Hafızayı Temizle

                    _terimsayisi1 = 0;
                    _terimsayisi2 = 0;
                    _terimsayisi3 = 0;
                    _terimsayisi4 = 0;
                    _terimsayisi5 = 0;
                    _ussayisi1 = 0;
                    _ussayisi2 = 0;
                    _ussayisi3 = 0;
                    _ussayisi4 = 0;
                    _ussayisi5 = 0;
                    _birinciTerimIslem = 0;
                    _ikinciTerimIslem = 0;
                    _ucuncuTerimIslem = 0;
                    _dorduncuTerimIslem = 0;
                    _besinciTerimIslem = 0;
                    _azalmamisus1 = 0;
                    _azalmamisus2 = 0;
                    _azalmamisus3 = 0;
                    _azalmamisus4 = 0;
                    _azalmamisus5 = 0;
                    _islem1 = "";
                    _islem2 = "";
                    _islem3 = "";
                    _islem4 = "";
                    _sonucislem1 = "";
                    _sonucislem2 = "";
                    _sonucislem3 = "";
                    _sonucislem4 = "";
                    _genelsonuc = "";
                    _xdegiskeni1 = "";
                    _xdegiskeni2 = "";
                    _xdegiskeni3 = "";
                    _xdegiskeni4 = "";
                    _xdegiskeni5 = "";
                    _p1 = "";
                    _p2 = "";
                    _p3 = "";
                    _p4 = "";
                    _p5 = "";
                    _u1 = "";
                    _u2 = "";
                    _u3 = "";
                    _u4 = "";
                    _u5 = "";

                    // Terim veya Üs Üzerinde Değişiklik Yapıldıysa Hafızayı Temizle



                    /*
                    // Sonuç Basıldıysa Alanları Temizle İsteğe Bağlı
                    birinciTerim.Text = "";
                    ikinciTerim.Text = "";
                    ucuncuTerim.Text = "";
                    dorduncuTerim.Text = "";
                    besinciTerim.Text = "";
                    altinciTerim.Text = "";
                    birinciIslem.Text = "";
                    ikinciIslem.Text = "";
                    ucuncuIslem.Text = "";
                    dorduncuIslem.Text = "";
                    birinciUs.Text = "";
                    ikinciUs.Text = "";
                    ucuncuUs.Text = "";
                    dorduncuUs.Text = "";
                    besinciUs.Text = "";
                    htmlLabel1.Text = @"<div style='text-align:center;padding:15%;font-weight: bold;font-size:20px;'>Sonuç Bölümü</div>";
                    // Sonuç Basıldıysa Alanları Temizle İsteğe Bağlı Bitiş
                    */
                }
            }
            catch (Exception exception)
            {
                if (exception is ArgumentOutOfRangeException)
                {
                    XtraMessageBox.Show("Bağımsız Değişken Aralık Dışında", "Kritik Hata");
                }
                else if (exception is FormatException)
                {
                    XtraMessageBox.Show("Biçim İstisnası", "Kritik Hata");
                }
                else
                {
                    throw;
                }



            }
        }

        // Temizle Butonu İşlemleri

        private void button2_Click_1(object sender, EventArgs e)
        {
            birinciTerim.Text = "";
            ikinciTerim.Text = "";
            ucuncuTerim.Text = "";
            dorduncuTerim.Text = "";
            besinciTerim.Text = "";
            altinciTerim.Text = "";
            birinciIslem.Text = "";
            ikinciIslem.Text = "";
            ucuncuIslem.Text = "";
            dorduncuIslem.Text = "";
            birinciUs.Text = "";
            ikinciUs.Text = "";
            ucuncuUs.Text = "";
            dorduncuUs.Text = "";
            besinciUs.Text = "";
            htmlLabel1.Text = @"<div style='text-align:center;padding:15%;font-weight: bold;font-size:20px;'>Sonuç Bölümü</div>";
            _terimsayisi1 = 0;
            _terimsayisi2 = 0;
            _terimsayisi3 = 0;
            _terimsayisi4 = 0;
            _terimsayisi5 = 0;
            _ussayisi1 = 0;
            _ussayisi2 = 0;
            _ussayisi3 = 0;
            _ussayisi4 = 0;
            _ussayisi5 = 0;
            _birinciTerimIslem = 0;
            _ikinciTerimIslem = 0;
            _ucuncuTerimIslem = 0;
            _dorduncuTerimIslem = 0;
            _besinciTerimIslem = 0;
            _azalmamisus1 = 0;
            _azalmamisus2 = 0;
            _azalmamisus3 = 0;
            _azalmamisus4 = 0;
            _azalmamisus5 = 0;
            _islem1 = "";
            _islem2 = "";
            _islem3 = "";
            _islem4 = "";
            _sonucislem1 = "";
            _sonucislem2 = "";
            _sonucislem3 = "";
            _sonucislem4 = "";
            _genelsonuc = "";
            _xdegiskeni1 = "";
            _xdegiskeni2 = "";
            _xdegiskeni3 = "";
            _xdegiskeni4 = "";
            _xdegiskeni5 = "";
            _p1 = "";
            _p2 = "";
            _p3 = "";
            _p4 = "";
            _p5 = "";
            _u1 = "";
            _u2 = "";
            _u3 = "";
            _u4 = "";
            _u5 = "";
        }
        // Temizle Butonu İşlemleri Bitiş
    }
}
