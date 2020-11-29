using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;
using pecs.db;
using System.Drawing;
using System.Text.RegularExpressions;
using pecs.state;

namespace pecs
{
    public enum FormName
    {
        None = 0,
        Login,
        LoginFail,
        LoginPass,
        Register,
        RegisterSuccess,
        Menu,
        FRM6,
        FRM7,
        PickImage,
        FRM8,
        FRM9,
        FRM10,
        FRM11,
        FRM12,
        FRM13,
        FRM14,
        FRM15,
        FRM16,
        FRM17,
        FRM18,
        FRM19,
        FRM20,
        FRM21,
        FRM22,
        FRM23,
        FRM24,
        FRM25,
        FRM26,
        FRM27,
        FRM28,
        FRM29,
        FRM30,
        FRM31,
        FRM32,
        FRM33,
        FRM34,
        FRM35,
        FRM36,
        FRM37,
        FRM38,
        FRM39,
        FRM40,
        FRM41,
        FRM42,
        FRM43,
        FRM44,
        FRM45,
        FRM46,
        FRM47,
        FRM48,
        FRM49,
        FRM50,
        FRM51,
        FRM52,
        FRM53,
        FRM54,
        FRM55,
        FRM56,
        FRM57,
        FRM58,
        FRM59,
        FRM60,
        FRM61,
        FRM62,
        FRM63,
        FRM64,
        FRM65,
        FRM66,
        FRM67,
        FRM68,
        FRM69,
        FRM70,
        FRM71,
        FRM72,
        FRM73,
        FRM74,
        FRM75,
        FRM76,
        FRM77,
        FRM78,
        FRM79,
        FRM80,
        FRM81,
        FRM82,
        FRM83,
        FRM84,
        FRM85,
        FRM86,
        FRM87,
        FRM88,
        FRM89,
        FRM90,
        FRM91
    }

    static class Program
    {
        static int GetImagePath(string path_s, out string[] imgFN)
        {
            int i = 0;
            String s = Environment.CurrentDirectory + "\\data\\" + path_s;
            if (Directory.GetFiles(s).Length > 0)
            {
                imgFN = new string[Directory.GetFiles(s).Length];
                foreach (string f in Directory.GetFiles(s))
                {
                    imgFN[i] = f;
                    i++;
                }
            }
            else
            {
                imgFN = new string[1];
            }

            return imgFN.Length;
        }

        static string studentName = "";
        static public Image choosenImage;
        static Point mainLocation;

        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 建立 SQLite 資料庫
            PecsDB.CreateDatabase();

            // 建立資料表 學生資料
            var creatStudentInfoTable =
                @"CREATE TABLE StudentInfo (Id int,StudentName string,Sex string,BirthYear string, BirthMon string,Class string,Require string,Memo string);";
            PecsDB.CreateTable(creatStudentInfoTable);

            // 建立資料表 使用資料
            var createUserInfoTable =
                @"CREATE TABLE UserInfo (Id int,StudentName string,LeaderName string, LastUseTime DateTime);";
            PecsDB.CreateTable(createUserInfoTable);

            foreach (string f in Directory.GetFiles(".\\data\\A"))
            {
                var res = f.Split('\\');
                var ff = res.Last();
                res = ff.Split('.');
                Console.WriteLine(res.ToString());
                Console.WriteLine(ff);
                ff = res[0];
                ImageInst.imageList.Add(new ImageModel(Image.FromFile(f), ff));
            }

            for (int i = 0; i < 5; i++)
            {
                ImageInst.imageList[i].selected = true;
            }

            FormName nextForm = FormName.Login;

            //PECSDB pecsDB = new PECSDB("Server = 139.223.150.199; Database = pecs; User Id = pecsuser; Password = pecsuser123PECS123;");
            //pecsDB.Connect();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            while (nextForm != FormName.None)
            {
                switch (nextForm)
                {
                    case FormName.Login:
                        frm1 f1 = new frm1();
                        f1.StartPosition = FormStartPosition.Manual;
                        f1.Location = new Point(0, 0);
                        f1.ShowDialog();
                        mainLocation = f1.Location;
                        studentName = f1.stuName;
                        nextForm = f1.ch;
                        break;
                    case FormName.Register:
                        frm4 freg = new frm4();
                        freg.StartPosition = FormStartPosition.Manual;
                        freg.Location = mainLocation;
                        freg.ShowDialog();
                        mainLocation = freg.Location;
                        nextForm = freg.ch;
                        break;
                    //case FormName.LoginFail:
                    //    frm2 floginfail = new frm2();
                    //    floginfail.ShowDialog();
                    //    nextForm = floginfail.ch;
                    //    break;
                    case FormName.LoginPass:
                        frm3 fLpass = new frm3(studentName);
                        fLpass.StartPosition = FormStartPosition.Manual;
                        fLpass.Location = mainLocation;
                        fLpass.ShowDialog();
                        mainLocation = fLpass.Location;
                        nextForm = fLpass.ch;
                        break;
                    case FormName.FRM6:
                        frm6 f6 = new frm6();
                        f6.StartPosition = FormStartPosition.Manual;
                        f6.Location = mainLocation;
                        f6.ShowDialog();
                        mainLocation = f6.Location;
                        nextForm = f6.ch;
                        break;
                    case FormName.FRM7:
                        frm7 fTech1 = new frm7();
                        fTech1.StartPosition = FormStartPosition.Manual;
                        fTech1.Location = mainLocation;
                        fTech1.ShowDialog();
                        mainLocation = fTech1.Location;
                        nextForm = fTech1.ch;
                        break;
                    case FormName.PickImage:
                        frmPickImage fpi = new frmPickImage();
                        fpi.StartPosition = FormStartPosition.Manual;
                        fpi.Location = mainLocation;
                        fpi.ShowDialog();
                        mainLocation = fpi.Location;
                        nextForm = fpi.ch;
                        break;
                    case FormName.FRM8:
                        frm8 f8 = new frm8();
                        f8.StartPosition = FormStartPosition.Manual;
                        f8.Location = mainLocation;
                        f8.ShowDialog();
                        mainLocation = f8.Location;
                        nextForm = f8.ch;
                        break;
                    case FormName.FRM9:
                        frm9 f9 = new frm9();
                        f9.StartPosition = FormStartPosition.Manual;
                        f9.Location = mainLocation;
                        f9.ShowDialog();
                        mainLocation = f9.Location;
                        nextForm = f9.ch;
                        break;
                    case FormName.FRM10:
                        frm10 f10 = new frm10();
                        f10.StartPosition = FormStartPosition.Manual;
                        f10.Location = mainLocation;
                        f10.ShowDialog();
                        mainLocation = f10.Location;
                        nextForm = f10.ch;
                        break;
                    case FormName.FRM11:
                        frm11 f11 = new frm11();
                        f11.StartPosition = FormStartPosition.Manual;
                        f11.Location = mainLocation;
                        f11.ShowDialog();
                        mainLocation = f11.Location;
                        nextForm = f11.ch;
                        break;
                    case FormName.FRM12:
                        frm12 f12 = new frm12();
                        f12.StartPosition = FormStartPosition.Manual;
                        f12.Location = mainLocation;
                        f12.ShowDialog();
                        mainLocation = f12.Location;
                        nextForm = f12.ch;
                        break;
                    case FormName.FRM13:
                        frm13 f13 = new frm13();
                        f13.StartPosition = FormStartPosition.Manual;
                        f13.Location = mainLocation;
                        f13.ShowDialog();
                        mainLocation = f13.Location;
                        nextForm = f13.ch;
                        break;
                    case FormName.FRM14:
                        frm14 f14 = new frm14();
                        f14.StartPosition = FormStartPosition.Manual;
                        f14.Location = mainLocation;
                        f14.ShowDialog();
                        mainLocation = f14.Location;
                        nextForm = f14.ch;
                        break;
                    case FormName.FRM15:
                        frm15 f15 = new frm15();
                        f15.StartPosition = FormStartPosition.Manual;
                        f15.Location = mainLocation;
                        f15.ShowDialog();
                        mainLocation = f15.Location;
                        nextForm = f15.ch;
                        break;
                    case FormName.FRM16:
                        frm16 f16 = new frm16();
                        f16.StartPosition = FormStartPosition.Manual;
                        f16.Location = mainLocation;
                        f16.ShowDialog();
                        mainLocation = f16.Location;
                        nextForm = f16.ch;
                        break;
                    case FormName.FRM17:
                        frm17 f17 = new frm17();
                        f17.StartPosition = FormStartPosition.Manual;
                        f17.Location = mainLocation;
                        f17.ShowDialog();
                        mainLocation = f17.Location;
                        nextForm = f17.ch;
                        break;
                    case FormName.FRM18:
                        frm18 f18 = new frm18();
                        f18.StartPosition = FormStartPosition.Manual;
                        f18.Location = mainLocation;
                        f18.ShowDialog();
                        mainLocation = f18.Location;
                        nextForm = f18.ch;
                        break;
                    case FormName.FRM19:
                        frm19 f19 = new frm19();
                        f19.StartPosition = FormStartPosition.Manual;
                        f19.Location = mainLocation;
                        f19.ShowDialog();
                        mainLocation = f19.Location;
                        nextForm = f19.ch;
                        break;
                    case FormName.FRM20:
                        frm20 f20 = new frm20();
                        f20.StartPosition = FormStartPosition.Manual;
                        f20.Location = mainLocation;
                        f20.ShowDialog();
                        mainLocation = f20.Location;
                        nextForm = f20.ch;
                        break;
                    case FormName.FRM21:
                        frm21 f21 = new frm21();
                        f21.StartPosition = FormStartPosition.Manual;
                        f21.Location = mainLocation;
                        f21.ShowDialog();
                        mainLocation = f21.Location;
                        nextForm = f21.ch;
                        break;
                    case FormName.FRM22:
                        frm22 f22 = new frm22();
                        f22.StartPosition = FormStartPosition.Manual;
                        f22.Location = mainLocation;
                        f22.ShowDialog();
                        mainLocation = f22.Location;
                        nextForm = f22.ch;
                        break;
                    case FormName.FRM23:
                        frm23 f23 = new frm23();
                        f23.StartPosition = FormStartPosition.Manual;
                        f23.Location = mainLocation;
                        f23.ShowDialog();
                        mainLocation = f23.Location;
                        nextForm = f23.ch;
                        break;
                    case FormName.FRM24:
                        frm24 f24 = new frm24();
                        f24.StartPosition = FormStartPosition.Manual;
                        f24.Location = mainLocation;
                        f24.ShowDialog();
                        mainLocation = f24.Location;
                        nextForm = f24.ch;
                        break;
                    case FormName.FRM25:
                        frm25 f25 = new frm25();
                        f25.StartPosition = FormStartPosition.Manual;
                        f25.Location = mainLocation;
                        f25.ShowDialog();
                        mainLocation = f25.Location;
                        nextForm = f25.ch;
                        break;
                    case FormName.FRM26:
                        frm26 f26 = new frm26();
                        f26.StartPosition = FormStartPosition.Manual;
                        f26.Location = mainLocation;
                        f26.ShowDialog();
                        mainLocation = f26.Location;
                        nextForm = f26.ch;
                        break;
                    case FormName.FRM27:
                        frm27 f27 = new frm27();
                        f27.StartPosition = FormStartPosition.Manual;
                        f27.Location = mainLocation;
                        f27.ShowDialog();
                        mainLocation = f27.Location;
                        nextForm = f27.ch;
                        break;
                    case FormName.FRM28:
                        frm28 f28 = new frm28();
                        f28.StartPosition = FormStartPosition.Manual;
                        f28.Location = mainLocation;
                        f28.ShowDialog();
                        mainLocation = f28.Location;
                        nextForm = f28.ch;
                        break;
                    case FormName.FRM29:
                        frm29 f29 = new frm29();
                        f29.StartPosition = FormStartPosition.Manual;
                        f29.Location = mainLocation;
                        f29.ShowDialog();
                        mainLocation = f29.Location;
                        nextForm = f29.ch;
                        break;
                    case FormName.FRM30:
                        frm30 f30 = new frm30();
                        f30.StartPosition = FormStartPosition.Manual;
                        f30.Location = mainLocation;
                        f30.ShowDialog();
                        mainLocation = f30.Location;
                        nextForm = f30.ch;
                        break;
                    case FormName.FRM31:
                        frm31 f31 = new frm31();
                        f31.StartPosition = FormStartPosition.Manual;
                        f31.Location = mainLocation;
                        f31.ShowDialog();
                        mainLocation = f31.Location;
                        nextForm = f31.ch;
                        break;
                    case FormName.FRM32:
                        frm32 f32 = new frm32();
                        f32.StartPosition = FormStartPosition.Manual;
                        f32.Location = mainLocation;
                        f32.ShowDialog();
                        mainLocation = f32.Location;
                        nextForm = f32.ch;
                        break;
                    case FormName.FRM33:
                        frm33 f33 = new frm33();
                        f33.StartPosition = FormStartPosition.Manual;
                        f33.Location = mainLocation;
                        f33.ShowDialog();
                        mainLocation = f33.Location;
                        nextForm = f33.ch;
                        break;
                    case FormName.FRM34:
                        frm34 f34 = new frm34();
                        f34.StartPosition = FormStartPosition.Manual;
                        f34.Location = mainLocation;
                        f34.ShowDialog();
                        mainLocation = f34.Location;
                        nextForm = f34.ch;
                        break;
                    case FormName.FRM35:
                        frm35 f35 = new frm35();
                        f35.StartPosition = FormStartPosition.Manual;
                        f35.Location = mainLocation;
                        f35.ShowDialog();
                        mainLocation = f35.Location;
                        nextForm = f35.ch;
                        break;
                    case FormName.FRM36:
                        frm36 f36 = new frm36();
                        f36.StartPosition = FormStartPosition.Manual;
                        f36.Location = mainLocation;
                        f36.ShowDialog();
                        mainLocation = f36.Location;
                        nextForm = f36.ch;
                        break;
                    case FormName.FRM37:
                        frm37 f37 = new frm37();
                        f37.StartPosition = FormStartPosition.Manual;
                        f37.Location = mainLocation;
                        f37.ShowDialog();
                        mainLocation = f37.Location;
                        nextForm = f37.ch;
                        break;
                    case FormName.FRM38:
                        frm38 f38 = new frm38();
                        f38.StartPosition = FormStartPosition.Manual;
                        f38.Location = mainLocation;
                        f38.ShowDialog();
                        mainLocation = f38.Location;
                        nextForm = f38.ch;
                        break;
                    case FormName.FRM39:
                        frm39 f39 = new frm39();
                        f39.StartPosition = FormStartPosition.Manual;
                        f39.Location = mainLocation;
                        f39.ShowDialog();
                        mainLocation = f39.Location;
                        nextForm = f39.ch;
                        break;
                    case FormName.FRM40:
                        frm40 f40 = new frm40();
                        f40.StartPosition = FormStartPosition.Manual;
                        f40.Location = mainLocation;
                        f40.ShowDialog();
                        mainLocation = f40.Location;
                        nextForm = f40.ch;
                        break;
                    case FormName.FRM41:
                        frm41 f41 = new frm41();
                        f41.StartPosition = FormStartPosition.Manual;
                        f41.Location = mainLocation;
                        f41.ShowDialog();
                        mainLocation = f41.Location;
                        nextForm = f41.ch;
                        break;
                    case FormName.FRM42:
                        frm42 f42 = new frm42();
                        f42.StartPosition = FormStartPosition.Manual;
                        f42.Location = mainLocation;
                        f42.ShowDialog();
                        mainLocation = f42.Location;
                        nextForm = f42.ch;
                        break;
                    case FormName.FRM43:
                        frm43 f43 = new frm43();
                        f43.StartPosition = FormStartPosition.Manual;
                        f43.Location = mainLocation;
                        f43.ShowDialog();
                        mainLocation = f43.Location;
                        nextForm = f43.ch;
                        break;
                    case FormName.FRM44:
                        frm44 f44 = new frm44();
                        f44.StartPosition = FormStartPosition.Manual;
                        f44.Location = mainLocation;
                        f44.ShowDialog();
                        mainLocation = f44.Location;
                        nextForm = f44.ch;
                        break;
                    case FormName.FRM45:
                        frm45 f45 = new frm45();
                        f45.StartPosition = FormStartPosition.Manual;
                        f45.Location = mainLocation;
                        f45.ShowDialog();
                        mainLocation = f45.Location;
                        nextForm = f45.ch;
                        break;
                    case FormName.FRM46:
                        frm46 f46 = new frm46();
                        f46.StartPosition = FormStartPosition.Manual;
                        f46.Location = mainLocation;
                        f46.ShowDialog();
                        mainLocation = f46.Location;
                        nextForm = f46.ch;
                        break;
                    case FormName.FRM47:
                        frm47 f47 = new frm47();
                        f47.StartPosition = FormStartPosition.Manual;
                        f47.Location = mainLocation;
                        f47.ShowDialog();
                        mainLocation = f47.Location;
                        nextForm = f47.ch;
                        break;
                    case FormName.FRM48:
                        frm48 f48 = new frm48();
                        f48.StartPosition = FormStartPosition.Manual;
                        f48.Location = mainLocation;
                        f48.ShowDialog();
                        mainLocation = f48.Location;
                        nextForm = f48.ch;
                        break;
                    case FormName.FRM49:
                        frm49 f49 = new frm49();
                        f49.StartPosition = FormStartPosition.Manual;
                        f49.Location = mainLocation;
                        f49.ShowDialog();
                        mainLocation = f49.Location;
                        nextForm = f49.ch;
                        break;
                    case FormName.FRM50:
                        frm50 f50 = new frm50();
                        f50.StartPosition = FormStartPosition.Manual;
                        f50.Location = mainLocation;
                        f50.ShowDialog();
                        mainLocation = f50.Location;
                        nextForm = f50.ch;
                        break;
                    case FormName.FRM51:
                        frm51 f51 = new frm51();
                        f51.StartPosition = FormStartPosition.Manual;
                        f51.Location = mainLocation;
                        f51.ShowDialog();
                        mainLocation = f51.Location;
                        nextForm = f51.ch;
                        break;
                    case FormName.FRM52:
                        frm52 f52 = new frm52();
                        f52.StartPosition = FormStartPosition.Manual;
                        f52.Location = mainLocation;
                        f52.ShowDialog();
                        mainLocation = f52.Location;
                        nextForm = f52.ch;
                        break;
                    case FormName.FRM53:
                        frm53 f53 = new frm53();
                        f53.StartPosition = FormStartPosition.Manual;
                        f53.Location = mainLocation;
                        f53.ShowDialog();
                        mainLocation = f53.Location;
                        nextForm = f53.ch;
                        break;
                    case FormName.FRM54:
                        frm54 f54 = new frm54();
                        f54.StartPosition = FormStartPosition.Manual;
                        f54.Location = mainLocation;
                        f54.ShowDialog();
                        mainLocation = f54.Location;
                        nextForm = f54.ch;
                        break;
                    case FormName.FRM55:
                        frm55 f55 = new frm55();
                        f55.StartPosition = FormStartPosition.Manual;
                        f55.Location = mainLocation;
                        f55.ShowDialog();
                        mainLocation = f55.Location;
                        nextForm = f55.ch;
                        break;
                    case FormName.FRM56:
                        frm56 f56 = new frm56();
                        f56.StartPosition = FormStartPosition.Manual;
                        f56.Location = mainLocation;
                        f56.ShowDialog();
                        mainLocation = f56.Location;
                        nextForm = f56.ch;
                        break;
                    case FormName.FRM57:
                        frm57 f57 = new frm57();
                        f57.StartPosition = FormStartPosition.Manual;
                        f57.Location = mainLocation;
                        f57.ShowDialog();
                        mainLocation = f57.Location;
                        nextForm = f57.ch;
                        break;
                    case FormName.FRM58:
                        frm58 f58 = new frm58();
                        f58.StartPosition = FormStartPosition.Manual;
                        f58.Location = mainLocation;
                        f58.ShowDialog();
                        mainLocation = f58.Location;
                        nextForm = f58.ch;
                        break;
                    case FormName.FRM59:
                        frm59 f59 = new frm59();
                        f59.StartPosition = FormStartPosition.Manual;
                        f59.Location = mainLocation;
                        f59.ShowDialog();
                        mainLocation = f59.Location;
                        nextForm = f59.ch;
                        break;
                    case FormName.FRM60:
                        frm60 f60 = new frm60();
                        f60.StartPosition = FormStartPosition.Manual;
                        f60.Location = mainLocation;
                        f60.ShowDialog();
                        mainLocation = f60.Location;
                        nextForm = f60.ch;
                        break;
                    case FormName.FRM61:
                        frm61 f61 = new frm61();
                        f61.StartPosition = FormStartPosition.Manual;
                        f61.Location = mainLocation;
                        f61.ShowDialog();
                        mainLocation = f61.Location;
                        nextForm = f61.ch;
                        break;
                    case FormName.FRM62:
                        frm62 f62 = new frm62();
                        f62.StartPosition = FormStartPosition.Manual;
                        f62.Location = mainLocation;
                        f62.ShowDialog();
                        mainLocation = f62.Location;
                        nextForm = f62.ch;
                        break;
                    case FormName.FRM63:
                        frm63 f63 = new frm63();
                        f63.StartPosition = FormStartPosition.Manual;
                        f63.Location = mainLocation;
                        f63.ShowDialog();
                        mainLocation = f63.Location;
                        nextForm = f63.ch;
                        break;
                    case FormName.FRM64:
                        frm64 f64 = new frm64();
                        f64.StartPosition = FormStartPosition.Manual;
                        f64.Location = mainLocation;
                        f64.ShowDialog();
                        mainLocation = f64.Location;
                        nextForm = f64.ch;
                        break;
                    case FormName.FRM65:
                        frm65 f65 = new frm65();
                        f65.StartPosition = FormStartPosition.Manual;
                        f65.Location = mainLocation;
                        f65.ShowDialog();
                        mainLocation = f65.Location;
                        nextForm = f65.ch;
                        break;
                    case FormName.FRM66:
                        frm66 f66 = new frm66();
                        f66.StartPosition = FormStartPosition.Manual;
                        f66.Location = mainLocation;
                        f66.ShowDialog();
                        mainLocation = f66.Location;
                        nextForm = f66.ch;
                        break;
                    case FormName.FRM67:
                        frm67 f67 = new frm67();
                        f67.StartPosition = FormStartPosition.Manual;
                        f67.Location = mainLocation;
                        f67.ShowDialog();
                        mainLocation = f67.Location;
                        nextForm = f67.ch;
                        break;
                    case FormName.FRM68:
                        frm68 f68 = new frm68();
                        f68.StartPosition = FormStartPosition.Manual;
                        f68.Location = mainLocation;
                        f68.ShowDialog();
                        mainLocation = f68.Location;
                        nextForm = f68.ch;
                        break;
                    case FormName.FRM69:
                        frm69 f69 = new frm69();
                        f69.StartPosition = FormStartPosition.Manual;
                        f69.Location = mainLocation;
                        f69.ShowDialog();
                        mainLocation = f69.Location;
                        nextForm = f69.ch;
                        break;
                    case FormName.FRM70:
                        frm70 f70 = new frm70();
                        f70.StartPosition = FormStartPosition.Manual;
                        f70.Location = mainLocation;
                        f70.ShowDialog();
                        mainLocation = f70.Location;
                        nextForm = f70.ch;
                        break;
                    case FormName.FRM71:
                        frm71 f71 = new frm71();
                        f71.StartPosition = FormStartPosition.Manual;
                        f71.Location = mainLocation;
                        f71.ShowDialog();
                        mainLocation = f71.Location;
                        nextForm = f71.ch;
                        break;
                    case FormName.FRM72:
                        frm72 f72 = new frm72();
                        f72.StartPosition = FormStartPosition.Manual;
                        f72.Location = mainLocation;
                        f72.ShowDialog();
                        mainLocation = f72.Location;
                        nextForm = f72.ch;
                        break;
                    case FormName.FRM73:
                        frm73 f73 = new frm73();
                        f73.StartPosition = FormStartPosition.Manual;
                        f73.Location = mainLocation;
                        f73.ShowDialog();
                        mainLocation = f73.Location;
                        nextForm = f73.ch;
                        break;
                    case FormName.FRM74:
                        frm74 f74 = new frm74();
                        f74.StartPosition = FormStartPosition.Manual;
                        f74.Location = mainLocation;
                        f74.ShowDialog();
                        mainLocation = f74.Location;
                        nextForm = f74.ch;
                        break;
                    case FormName.FRM75:
                        frm75 f75 = new frm75();
                        f75.StartPosition = FormStartPosition.Manual;
                        f75.Location = mainLocation;
                        f75.ShowDialog();
                        mainLocation = f75.Location;
                        nextForm = f75.ch;
                        break;
                    case FormName.FRM76:
                        frm76 f76 = new frm76();
                        f76.StartPosition = FormStartPosition.Manual;
                        f76.Location = mainLocation;
                        f76.ShowDialog();
                        mainLocation = f76.Location;
                        nextForm = f76.ch;
                        break;
                    case FormName.FRM77:
                        frm77 f77 = new frm77();
                        f77.StartPosition = FormStartPosition.Manual;
                        f77.Location = mainLocation;
                        f77.ShowDialog();
                        mainLocation = f77.Location;
                        nextForm = f77.ch;
                        break;
                    case FormName.FRM78:
                        frm78 f78 = new frm78();
                        f78.StartPosition = FormStartPosition.Manual;
                        f78.Location = mainLocation;
                        f78.ShowDialog();
                        mainLocation = f78.Location;
                        nextForm = f78.ch;
                        break;
                    case FormName.FRM79:
                        frm79 f79 = new frm79();
                        f79.StartPosition = FormStartPosition.Manual;
                        f79.Location = mainLocation;
                        f79.ShowDialog();
                        mainLocation = f79.Location;
                        nextForm = f79.ch;
                        break;
                    case FormName.FRM80:
                        frm80 f80 = new frm80();
                        f80.StartPosition = FormStartPosition.Manual;
                        f80.Location = mainLocation;
                        f80.ShowDialog();
                        mainLocation = f80.Location;
                        nextForm = f80.ch;
                        break;
                    case FormName.FRM81:
                        frm81 f81 = new frm81();
                        f81.StartPosition = FormStartPosition.Manual;
                        f81.Location = mainLocation;
                        f81.ShowDialog();
                        mainLocation = f81.Location;
                        nextForm = f81.ch;
                        break;
                    case FormName.FRM82:
                        frm82 f82 = new frm82();
                        f82.StartPosition = FormStartPosition.Manual;
                        f82.Location = mainLocation;
                        f82.ShowDialog();
                        mainLocation = f82.Location;
                        nextForm = f82.ch;
                        break;
                    case FormName.FRM83:
                        frm83 f83 = new frm83();
                        f83.StartPosition = FormStartPosition.Manual;
                        f83.Location = mainLocation;
                        f83.ShowDialog();
                        mainLocation = f83.Location;
                        nextForm = f83.ch;
                        break;
                    case FormName.FRM84:
                        frm84 f84 = new frm84();
                        f84.StartPosition = FormStartPosition.Manual;
                        f84.Location = mainLocation;
                        f84.ShowDialog();
                        mainLocation = f84.Location;
                        nextForm = f84.ch;
                        break;
                    case FormName.FRM85:
                        frm85 f85 = new frm85();
                        f85.StartPosition = FormStartPosition.Manual;
                        f85.Location = mainLocation;
                        f85.ShowDialog();
                        mainLocation = f85.Location;
                        nextForm = f85.ch;
                        break;
                    case FormName.FRM86:
                        frm86 f86 = new frm86();
                        f86.StartPosition = FormStartPosition.Manual;
                        f86.Location = mainLocation;
                        f86.ShowDialog();
                        mainLocation = f86.Location;
                        nextForm = f86.ch;
                        break;
                    case FormName.FRM87:
                        frm87 f87 = new frm87();
                        f87.StartPosition = FormStartPosition.Manual;
                        f87.Location = mainLocation;
                        f87.ShowDialog();
                        mainLocation = f87.Location;
                        nextForm = f87.ch;
                        break;
                    case FormName.FRM88:
                        frm88 f88 = new frm88();
                        f88.StartPosition = FormStartPosition.Manual;
                        f88.Location = mainLocation;
                        f88.ShowDialog();
                        mainLocation = f88.Location;
                        nextForm = f88.ch;
                        break;
                    case FormName.FRM89:
                        frm89 f89 = new frm89();
                        f89.StartPosition = FormStartPosition.Manual;
                        f89.Location = mainLocation;
                        f89.ShowDialog();
                        mainLocation = f89.Location;
                        nextForm = f89.ch;
                        break;
                    case FormName.FRM90:
                        frm90 f90 = new frm90();
                        f90.StartPosition = FormStartPosition.Manual;
                        f90.Location = mainLocation;
                        f90.ShowDialog();
                        mainLocation = f90.Location;
                        nextForm = f90.ch;
                        break;
                    case FormName.FRM91:
                        frm91 f91 = new frm91();
                        f91.StartPosition = FormStartPosition.Manual;
                        f91.Location = mainLocation;
                        f91.ShowDialog();
                        mainLocation = f91.Location;
                        nextForm = f91.ch;
                        break;
                    default:
                        nextForm = FormName.None;
                        break;
                }
            }

            //pecsDB.DisConnect();
        }
    }
}