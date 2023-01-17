using System;
using System.IO;
using System.Windows.Forms;

namespace Расчёт_ступени_ЦВД_паровой_турбины_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Переменные
        //Переменные, которые надо ввести:

        public double p0, t0, G, n, c0, H0, dp0, d, b1_l1, a1e, p, h0, p1, v1t, h1t, p2, v2t, h2t_, k2, t1_1, b1, d1, d2, b2, t1_3, x_vs, k_y, nu_y, d_y, dd_y, nu_a, nu_r, dd_a, dd_r, z_p, BB_y, i, W_min_atl, b_atl, h2t;
        public int z_d;

        //Получившиеся переменные:

        public double p10, u, cf, u_cf, f, u_cf_o, H0c, H0p, H0_, c1t, nu1, F1, e_l1, e_o, l1, M1t, b1_l1_p, f_n, u_cf_o_n, nu1_n, F1_n, e_l1_n, e_o_n, l1_n, b1_l1_n, z1, t1_2, c1, w1, BB1, dHc, w2t, l2_mm, l2_m, b2_l2, nu2, F2, BB2e, M2t, z2, t2, ww, w2, BB2, c2, a_2, dHp, dHvc, E0, n_ol1, n_ol2, n_ol3, n_olsr, cc_tr, e1, x, F_y, cc_dd_y, d_per, dd_ekv, cc_p_y, cc_y, cc_vent, B2, cc_segm, cc_parc, n_oi, N_i, h2, dHtr, dHy, dHparc, Hi_reg;

        public double w, o_p, W_min, o_izg;

        //Переменные, необходимые для расчётов:

        public double pi = Math.PI;
        public const double k = 0.667;
        public const double e_kr = 0.5457277;
        public const double p_st = 7800;
        public const double k_tr = 0.003;
        public const double k_v = 0.065;
        public const double k_segm = 0.25;
        #endregion

        public void Check()
        {
            if (radioButton1.Checked)
            {
                a26.ReadOnly = true;
                a27.ReadOnly = true;
                a28.ReadOnly = true;
                a29.ReadOnly = true;
                a30.ReadOnly = true;
                a5.ReadOnly = true;
                a6.ReadOnly = false;
                a7.ReadOnly = false;
                a38.ReadOnly = false;
                a39.ReadOnly = false;
                a111.ReadOnly = false;
                a98.ReadOnly = true;

                a6.Text = "";
                a7.Text = "";
                a38.Text = "";
                a39.Text = "";
                a40.Text = "";
                a43.Text = "";
                a51.Text = "";
                a52.Text = "";
                a95.Text = "";
                a96.Text = "";
                a97.Text = "";
                a100.Text = "";
                a111.Text = "";
                a60.Text = "";
                a61.Text = "";
                a5.Text = "Не задаётся";
                a26.Text = "Не задаётся";
                a27.Text = "Не задаётся";
                a28.Text = "Не задаётся";
                a29.Text = "Не задаётся";
                a30.Text = "Не задаётся";
                a98.Text = "0";
                a89.Text = "Не рассчитывается";
                a90.Text = "Не рассчитывается";
            }

            else
            {
                a5.ReadOnly = false;
                a26.ReadOnly = false;
                a27.ReadOnly = false;
                a28.ReadOnly = false;
                a29.ReadOnly = false;
                a30.ReadOnly = false;
                a98.ReadOnly = false;
                a6.ReadOnly = true;
                a7.ReadOnly = true;
                a38.ReadOnly = true;
                a39.ReadOnly = true;
                a111.ReadOnly = true;

                a6.Text = "Не рассчитывается";
                a7.Text = "Не рассчитывается";
                a38.Text = "Не рассчитывается";
                a39.Text = "Не рассчитывается";
                a40.Text = "Не рассчитывается";
                a43.Text = "Не рассчитывается";
                a51.Text = "Не рассчитывается";
                a52.Text = "Не рассчитывается";
                a95.Text = "Не рассчитывается";
                a96.Text = "Не рассчитывается";
                a97.Text = "Не рассчитывается";
                a100.Text = "Не рассчитывается";
                a111.Text = "Не рассчитывается";
                a60.Text = "Не рассчитывается";
                a61.Text = "Не рассчитывается";
                a26.Text = "";
                a27.Text = "";
                a28.Text = "";
                a29.Text = "";
                a30.Text = "";
                a5.Text = "";
                a89.Text = "";
                a98.Text = "";
                a90.Text = "";
            }

            if (radioButton2.Checked) { a6.ReadOnly = true; a6.Text = "Не рассчитывается";}
            else { a6.ReadOnly = false; a6.Text = ""; }
        }

        public void ConvertOut(double var, int numb, TextBox n)
        {
            n.Text = Convert.ToString(Math.Round(var, numb));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Газодинамический расчёт

            p0 = Convert.ToDouble(a1.Text);
            t0 = Convert.ToDouble(a2.Text);
            G = Convert.ToDouble(a3.Text);
            n = Convert.ToDouble(a4.Text);
            if (radioButton1.Checked == false) c0 = Convert.ToDouble(a5.Text);
            if (radioButton1.Checked) dp0 = Convert.ToDouble(a7.Text) / 100;
            d = Convert.ToDouble(a8.Text);
            b1_l1 = Convert.ToDouble(a9.Text);
            a1e = Convert.ToDouble(a10.Text);
            p = Convert.ToDouble(a11.Text);
            h0 = Convert.ToDouble(a12.Text);
            p1 = Convert.ToDouble(a13.Text);
            v1t = Convert.ToDouble(a14.Text);
            h1t = Convert.ToDouble(a15.Text);
            p2 = Convert.ToDouble(a16.Text);
            v2t = Convert.ToDouble(a17.Text);
            h2t_ = Convert.ToDouble(a18.Text);
            t1_1 = Convert.ToDouble(a19.Text);
            b1 = Convert.ToDouble(a20.Text);
            d1 = Convert.ToDouble(a21.Text);
            d2 = Convert.ToDouble(a22.Text);
            b2 = Convert.ToDouble(a23.Text);
            t1_3 = Convert.ToDouble(a24.Text);
            if (radioButton2.Checked) { a6.Text = "Не рассчитывается"; H0 = h0 - h2t_; }
            else { H0 = Convert.ToDouble(a6.Text); };
            if (radioButton1.Checked) x_vs = 0;
            else x_vs = Convert.ToDouble(a98.Text);
            if (radioButton1.Checked == false) k_y = Convert.ToDouble(a26.Text);
            if (radioButton1.Checked == false) nu_y = Convert.ToDouble(a27.Text);
            if (radioButton1.Checked == false) d_y = Convert.ToDouble(a28.Text);
            if (radioButton1.Checked == false) dd_y = Convert.ToDouble(a29.Text);
            if (radioButton1.Checked == false) z_d = Convert.ToInt32(a30.Text);
            nu_a = Convert.ToDouble(a31.Text);
            nu_r = Convert.ToDouble(a32.Text);
            dd_a = Convert.ToDouble(a33.Text);
            dd_r = Convert.ToDouble(a34.Text);
            z_p = Convert.ToDouble(a35.Text);
            if (radioButton1.Checked) BB_y = Convert.ToDouble(a38.Text);
            if (radioButton1.Checked) i = Convert.ToDouble(a39.Text);
            if (radioButton1.Checked) k2 = Convert.ToDouble(a111.Text);
            W_min_atl = Convert.ToDouble(a107.Text);
            b_atl = Convert.ToDouble(a108.Text);
            h2t = Convert.ToDouble(a115.Text);


            if (radioButton1.Checked)
            {
                p10 = p0 - p0 * dp0;
                ConvertOut(p10, 3, a40);
            }

            u = pi * d * n;
            ConvertOut(u, 2, a41);

            f = 0.98 - 0.008 * b1_l1;
            ConvertOut(f, 4, a44);

            u_cf_o = (f * Math.Cos((a1e * pi) / 180)) / (2 * Math.Sqrt(1 - p));
            ConvertOut(u_cf_o, 4, a45);

            if (radioButton2.Checked) cf = u / u_cf_o;
            else cf = Math.Sqrt(2 * H0 * 1000);
            ConvertOut(cf, 2, a42);

            if (radioButton1.Checked == false) { H0_ = (cf * cf) / 2; }
            
            if (radioButton1.Checked)
            {
                u_cf = u / cf;
                ConvertOut(u_cf, 4, a43);
            }

            if (radioButton1.Checked == false) H0c = ((1 - p) * H0_) / 1000;
            else H0c = (1 - p) * H0;
            ConvertOut(H0c, 3, a46);

            if (radioButton1.Checked == false) H0p = (p * H0_) / 1000;
            else H0p = p * H0;
            ConvertOut(H0p, 3, a47);

            c1t = Math.Sqrt(2 * H0c * 1000);
            ConvertOut(c1t, 2, a48);

            nu1 = 0.982 - 0.005 * b1_l1;
            ConvertOut(nu1, 4, a49);

            F1 = (G * v1t) / (nu1 * c1t);
            ConvertOut(F1, 5, a50);

            if (radioButton1.Checked) 
            { 
                e_l1 = F1 / (pi * d * Math.Sin((a1e * pi) / 180));
                ConvertOut(e_l1, 5, a51);
            }

            if (radioButton1.Checked)
            {
                e_o = k2 * Math.Sqrt(e_l1);
                ConvertOut(e_o, 3, a52);
            }
            else e_o = 1;

            if (radioButton1.Checked) { l1 = (e_l1 / e_o) * 1000; }
            else { l1 = (F1 / (pi * d * Math.Sin((a1e * pi) / 180))) * 1000; }
            ConvertOut(l1, 2, a53);

            M1t = c1t / Math.Sqrt(1.3 * p1 * 1000000 * v1t);
            ConvertOut(M1t, 3, a54);

            b1_l1_p = b1 / l1;
            ConvertOut(b1_l1_p, 2, a55);

            f_n = 0.98 - 0.008 * b1_l1_p;
            ConvertOut(f_n, 4, a56);

            u_cf_o_n = (f_n * Math.Cos((a1e * pi) / 180)) / (2 * Math.Sqrt(1 - p));
            ConvertOut(u_cf_o_n, 4, a57);

            nu1_n = 0.982 - 0.005 * b1_l1_p;
            ConvertOut(nu1_n, 4, a58);

            F1_n = (G * v1t) / (nu1_n * c1t);
            ConvertOut(F1_n, 5, a59);

            if (radioButton1.Checked)
            {
                e_l1_n = F1_n / (pi * d * Math.Sin((a1e * pi) / 180));
                ConvertOut(e_l1_n, 5, a60);
            }
            
            if (radioButton1.Checked)
            {
                e_o_n = k2 * Math.Sqrt(e_l1_n);
                ConvertOut(e_o_n, 3, a61);
            }
            else e_o_n = 1;

            if (radioButton1.Checked) l1_n = l1_n = (e_l1_n / e_o_n) * 1000;
            else l1_n = (F1_n / (pi * d * Math.Sin((a1e * pi) / 180))) * 1000;
            ConvertOut(l1_n, 2, a62);

            b1_l1_n = b1 / l1_n;
            ConvertOut(b1_l1_n, 2, a63);

            z1 = (pi * d) / ((b1 / 1000) * t1_1);
            if (Math.Truncate(z1) % 2 != 0) { z1 = Math.Ceiling(z1); }
            else { z1 = Math.Floor(z1); }
            ConvertOut(z1, 0, a64);

            t1_2 = (pi * d) / ((b1 / 1000) * z1);
            ConvertOut(t1_2, 3, a65);

            c1 = c1t * f_n;
            ConvertOut(c1, 2, a66);

            w1 = Math.Sqrt(Math.Pow(c1, 2) + Math.Pow(u, 2) - 2 * c1 * u * Math.Cos((a1e * pi) / 180));
            ConvertOut(w1, 2, a67);

            BB1 = Math.Atan(Math.Sin((a1e * pi) / 180) / (Math.Cos((a1e * pi) / 180) - (u / c1))) * 180 / pi;
            ConvertOut(BB1, 2, a68);

            dHc = ((1 - (f_n * f_n)) * ((c1t * c1t) / 2)) / 1000;
            ConvertOut(dHc, 3, a69);

            w2t = Math.Sqrt(2 * H0p * 1000 + Math.Pow(w1, 2));
            ConvertOut(w2t, 2, a70);

            l2_mm = l1_n + (d1 + d2);
            ConvertOut(l2_mm, 2, a71);

            l2_m = l2_mm / 1000;

            b2_l2 = b2 / l2_mm;
            ConvertOut(b2_l2, 2, a72);

            nu2 = 0.965 - 0.01 * b2_l2;
            ConvertOut(nu2, 4, a73);

            F2 = (G * v2t) / (nu2 * w2t);
            ConvertOut(F2, 5, a74);

            BB2e = Math.Asin(F2 / (pi * d * l2_m)) * 180 / pi;
            ConvertOut(BB2e, 2, a75);

            M2t = w2t / Math.Sqrt(1.3 * p2 * 1000000 * v2t);
            ConvertOut(M2t, 3, a76);

            z2 = Math.Round((pi * d) / ((b2 / 1000) * t1_3));
            ConvertOut(z2, 0, a77);

            t2 = (pi * d) / ((b2 / 1000) * z2);
            ConvertOut(t2, 4, a78);

            ww = 0.96 - 0.014 * b2_l2;
            ConvertOut(ww, 4, a79);

            w2 = ww * w2t;
            ConvertOut(w2, 2, a80);

            BB2 = Math.Asin(Math.Sin((BB2e * pi) / 180) * (nu2 / ww)) * 180 / pi;
            ConvertOut(BB2, 2, a81);

            c2 = Math.Sqrt(Math.Pow(w2, 2) + Math.Pow(u, 2) - 2 * w2 * u * Math.Cos((BB2 * pi) / 180));
            ConvertOut(c2, 2, a82);

            a_2 = Math.Atan(Math.Sin((BB2 * pi) / 180) / (Math.Cos((BB2 * pi) / 180) - (u / w2))) * 180 / pi;
            if (a_2 < 0) { a_2 = 180 + a_2; }
            ConvertOut(a_2, 2, a83);

            dHp = (1 - (ww * ww)) * ((w2t * w2t) / 2) / 1000;
            ConvertOut(dHp, 3, a84);

            dHvc = (Math.Pow(c2, 2) / 2) / 1000;
            ConvertOut(dHvc, 3, a85);

            if (radioButton1.Checked) E0 = H0 - x_vs * ((c2 * c2) / 2);
            else E0 = (H0_ - x_vs * ((c2 * c2) / 2)) / 1000;
            ConvertOut(E0, 3, a86);

            n_ol1 = (u * (c1 * Math.Cos((a1e * pi) / 180) + c2 * Math.Cos((a_2 * pi) / 180))) / (E0 * 1000);
            ConvertOut(n_ol1, 6, a87);
            ConvertOut(n_ol1, 5, a87);

            n_ol2 = (u * (w1 * Math.Cos((BB1 * pi) / 180) + w2 * Math.Cos((BB2 * pi) / 180))) / (E0 * 1000);
            ConvertOut(n_ol2, 6, a112);
            ConvertOut(n_ol2, 5, a112);

            n_ol3 = (E0 - dHc - dHp - dHvc * (1 - x_vs)) / E0;
            ConvertOut(n_ol3, 6, a113);
            ConvertOut(n_ol3, 5, a113);

            n_olsr = (n_ol1 + n_ol2 + n_ol3) / 3;
            ConvertOut(n_olsr, 6, a114);
            ConvertOut(n_olsr, 5, a114);

            if (radioButton1.Checked) cc_tr = k_tr * (Math.Pow(d, 2) / F1_n) * Math.Pow((u_cf), 3);
            else cc_tr = k_tr * (Math.Pow(d, 2) / F1_n) * Math.Pow((u_cf_o_n), 3);
            ConvertOut(cc_tr, 5, a88);

            if (radioButton1.Checked) e1 = e1 = p1 / p10;
            else e1 = p1 / p0;
            ConvertOut(e1, 3, a104);

            x = ((1 - e_kr) / 0.66726235124) * Math.Sqrt((1 - Math.Pow(e1, 2)) / (Math.Pow((1 - e_kr), 2) - Math.Pow((e_kr - e1), 2)));
            ConvertOut(x, 3, a103);

            if (radioButton1.Checked == false)
            {
                F_y = pi * d_y * dd_y * 0.001;
                ConvertOut(F_y, 5, a89);
            }

            if (radioButton1.Checked == false)
            {
                cc_dd_y = x * ((k_y * nu_y * F_y) / (nu1 * F1 * Math.Sqrt(z_d))) * n_olsr;
                ConvertOut(cc_dd_y, 5, a90);
            }

            d_per = d + l2_m;
            ConvertOut(d_per, 5, a91);

            dd_ekv = 1 / Math.Sqrt((1 / Math.Pow((nu_a * dd_a), 2)) + (z_p / Math.Pow((nu_r * dd_r), 2)));
            ConvertOut(dd_ekv, 4, a92);

            cc_p_y = ((pi * d_per * dd_ekv * 0.001) / F1_n) * Math.Sqrt(p + 1.7 * (l2_m / d)) * n_olsr;
            ConvertOut(cc_p_y, 5, a93);

            if (radioButton1.Checked) cc_y = cc_p_y;
            else cc_y = cc_dd_y + cc_p_y;
            ConvertOut(cc_y, 5, a94);

            if (radioButton1.Checked)
            {
                cc_vent = (k_v / Math.Sin((a1e * pi) / 180)) * ((1 - e_o_n) / e_o_n) * Math.Pow(u_cf, 3);
                ConvertOut(cc_vent, 5, a95);
            }

            if (radioButton1.Checked)
            {
                B2 = (b2 * Math.Sin((BB_y * pi) / 180)) / 1000;
                ConvertOut(B2, 5, a96);
            }

            if (radioButton1.Checked)
            {
                cc_segm = k_segm * ((B2 * l2_m) / F1_n) * u_cf * n_olsr * i;
                ConvertOut(cc_segm, 5, a97);
            }

            if (radioButton1.Checked)
            {
                cc_parc = cc_vent + cc_segm;
                ConvertOut(cc_parc, 5, a100);
            }

            if (radioButton1.Checked) { n_oi = n_olsr - cc_tr - cc_y - cc_parc; }
            else { n_oi = n_olsr - cc_tr - cc_y; }
            ConvertOut(n_oi, 5, a101);

            N_i = (G * H0 * n_oi) / 1000;
            ConvertOut(N_i, 3, a102);

            h2 = h2t + dHp;
            ConvertOut(h2, 3, a117);

            dHtr = cc_tr * E0;
            ConvertOut(dHtr, 3, a118);

            dHy = cc_y * E0;
            ConvertOut(dHy, 3, a119);

            dHparc = cc_parc * E0;
            ConvertOut(dHparc, 3, a120);

            h2 = h2 + dHtr + dHy + dHparc + dHvc;
            ConvertOut(h2, 3, a121);

            Hi_reg = h0 - h2;
            ConvertOut(Hi_reg, 3, a122);

            #endregion 

            #region Прочностной расчёт

            w = 2 * pi * n;
            ConvertOut(w, 3, a105);

            o_p = (0.5 * p_st * Math.Pow(w, 2) * d * l2_m) / 1000000;
            ConvertOut(o_p, 3, a106);

            W_min = W_min_atl * Math.Pow((b2 / b_atl), 3);
            ConvertOut(W_min, 3, a109);

            o_izg = ((G * H0 * 1000 * n_olsr * l2_m) / (2 * u * e_o_n * z2 * W_min * Math.Pow(10, -6))) / 1000000;
            ConvertOut(o_izg, 3, a110);

            #endregion

            button2.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Check();
        }

        public string path;
        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter =
            "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.ShowDialog();
            path = dialog.FileName;
            if (String.IsNullOrEmpty(path) == false)
            {
                char[] trimChars = { 't', 'x', '.' };
                this.Text = dialog.SafeFileName.TrimEnd(trimChars);
                FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader stream = new StreamReader(file);

                string stage = stream.ReadLine();
                if (stage == "Регулирующая") radioButton1.Checked = true;
                else if (stage == "В группе") radioButton2.Checked = true;
                else if (stage == "Одиночная") radioButton3.Checked = true;
                Check();

                a1.Text = stream.ReadLine();
                a2.Text = stream.ReadLine();
                a3.Text = stream.ReadLine();
                a4.Text = stream.ReadLine();
                if (radioButton1.Checked == false) a5.Text = stream.ReadLine();
                if (radioButton2.Checked == false) a6.Text = stream.ReadLine();
                if (radioButton1.Checked) a7.Text = stream.ReadLine();
                a8.Text = stream.ReadLine();
                a9.Text = stream.ReadLine();
                a10.Text = stream.ReadLine();
                a11.Text = stream.ReadLine();
                a12.Text = stream.ReadLine();
                a13.Text = stream.ReadLine();
                a14.Text = stream.ReadLine();
                a15.Text = stream.ReadLine();
                a16.Text = stream.ReadLine();
                a17.Text = stream.ReadLine();
                a18.Text = stream.ReadLine();
                if (radioButton1.Checked) a111.Text = stream.ReadLine();
                a19.Text = stream.ReadLine();
                a20.Text = stream.ReadLine();
                a21.Text = stream.ReadLine();
                a22.Text = stream.ReadLine();
                a23.Text = stream.ReadLine();
                a24.Text = stream.ReadLine();
                if (radioButton1.Checked == false) a98.Text = stream.ReadLine();
                if (radioButton1.Checked == false) a26.Text = stream.ReadLine();
                if (radioButton1.Checked == false) a27.Text = stream.ReadLine();
                if (radioButton1.Checked == false) a28.Text = stream.ReadLine();
                if (radioButton1.Checked == false) a29.Text = stream.ReadLine();
                if (radioButton1.Checked == false) a30.Text = stream.ReadLine();
                a31.Text = stream.ReadLine();
                a32.Text = stream.ReadLine();
                a33.Text = stream.ReadLine();
                a34.Text = stream.ReadLine();
                a35.Text = stream.ReadLine();
                if (radioButton1.Checked) a38.Text = stream.ReadLine();
                if (radioButton1.Checked) a39.Text = stream.ReadLine();
                a107.Text = stream.ReadLine();
                a108.Text = stream.ReadLine();
                a115.Text = stream.ReadLine();
                stream.Close();
                Clear();
                button2.Enabled = false;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(path))
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter =
            "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFile.ShowDialog();
                path = saveFile.FileName;
            }
            if (String.IsNullOrEmpty(path) == false)
            {
                FileStream file = new FileStream(path, FileMode.Create, FileAccess.ReadWrite);
                StreamWriter writer = new StreamWriter(file);

                if (radioButton1.Checked) writer.WriteLine("Регулирующая");
                else if (radioButton2.Checked) writer.WriteLine("В группе");
                else if (radioButton3.Checked) writer.WriteLine("Одиночная");

                writer.WriteLine(a1.Text);
                writer.WriteLine(a2.Text);
                writer.WriteLine(a3.Text);
                writer.WriteLine(a4.Text);
                if (radioButton1.Checked == false) writer.WriteLine(a5.Text);
                if (radioButton2.Checked == false) writer.WriteLine(a6.Text);
                if (radioButton1.Checked) writer.WriteLine(a7.Text);
                writer.WriteLine(a8.Text);
                writer.WriteLine(a9.Text);
                writer.WriteLine(a10.Text);
                writer.WriteLine(a11.Text);
                writer.WriteLine(a12.Text);
                writer.WriteLine(a13.Text);
                writer.WriteLine(a14.Text);
                writer.WriteLine(a15.Text);
                writer.WriteLine(a16.Text);
                writer.WriteLine(a17.Text);
                writer.WriteLine(a18.Text);
                if (radioButton1.Checked) writer.WriteLine(a111.Text);
                writer.WriteLine(a19.Text);
                writer.WriteLine(a20.Text);
                writer.WriteLine(a21.Text);
                writer.WriteLine(a22.Text);
                writer.WriteLine(a23.Text);
                writer.WriteLine(a24.Text);
                if (radioButton1.Checked == false) writer.WriteLine(a98.Text);
                if (radioButton1.Checked == false) writer.WriteLine(a26.Text);
                if (radioButton1.Checked == false) writer.WriteLine(a27.Text);
                if (radioButton1.Checked == false) writer.WriteLine(a28.Text);
                if (radioButton1.Checked == false) writer.WriteLine(a29.Text);
                if (radioButton1.Checked == false) writer.WriteLine(a30.Text);
                writer.WriteLine(a31.Text);
                writer.WriteLine(a32.Text);
                writer.WriteLine(a33.Text);
                writer.WriteLine(a34.Text);
                writer.WriteLine(a35.Text);
                if (radioButton1.Checked) writer.WriteLine(a38.Text);
                if (radioButton1.Checked) writer.WriteLine(a39.Text);
                writer.WriteLine(a107.Text);
                writer.WriteLine(a108.Text);
                writer.WriteLine(a115.Text);
                writer.Close();
            }
        }

        private void closeFile_Click(object sender, EventArgs e)
        {
            Text = "Расчёт ступени ЦВД паровой турбины";
            path = null;
            Clear();
            button2.Enabled = false;
        }

        public void Clear()
        {
            if (radioButton1.Checked == false)
            {
                a40.Text = "Не рассчитывается";
                a43.Text = "Не рассчитывается";
                a51.Text = "Не рассчитывается";
                a52.Text = "Не рассчитывается";
                a60.Text = "Не рассчитывается";
                a61.Text = "Не рассчитывается";
                a95.Text = "Не рассчитывается";
                a96.Text = "Не рассчитывается";
                a97.Text = "Не рассчитывается";
                a100.Text = "Не рассчитывается";

                a89.Clear();
                a90.Clear();
            }
            else
            {
                a89.Text = "Не рассчитывается";
                a90.Text = "Не рассчитывается";

                a40.Clear();
                a43.Clear();
                a51.Clear();
                a52.Clear();
                a60.Clear();
                a61.Clear();
                a95.Clear();
                a96.Clear();
                a97.Clear();
                a100.Clear();
            }

            a41.Clear();
            a42.Clear();
            a44.Clear();
            a45.Clear();
            a46.Clear();
            a47.Clear();
            a48.Clear();
            a49.Clear();
            a50.Clear();
            a53.Clear();
            a54.Clear();
            a55.Clear();
            a56.Clear();
            a57.Clear();
            a58.Clear();
            a59.Clear();
            a62.Clear();
            a63.Clear();
            a64.Clear();
            a65.Clear();
            a66.Clear();
            a67.Clear();
            a68.Clear();
            a69.Clear();
            a70.Clear();
            a71.Clear();
            a72.Clear();
            a73.Clear();
            a74.Clear();
            a75.Clear();
            a76.Clear();
            a77.Clear();
            a78.Clear();
            a79.Clear();
            a80.Clear();
            a81.Clear();
            a82.Clear();
            a83.Clear();
            a84.Clear();
            a85.Clear();
            a86.Clear();
            a87.Clear();
            a88.Clear();
            a91.Clear();
            a92.Clear();
            a93.Clear();
            a94.Clear();
            a101.Clear();
            a102.Clear();
            a103.Clear();
            a104.Clear();
            a105.Clear();
            a106.Clear();
            a109.Clear();
            a110.Clear();
            a112.Clear();
            a113.Clear();
            a114.Clear();
            a117.Clear();
            a118.Clear();
            a119.Clear();
            a120.Clear();
            a121.Clear();
            a122.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2(h2, G);
            Form2.ShowDialog();
        }
    }
}