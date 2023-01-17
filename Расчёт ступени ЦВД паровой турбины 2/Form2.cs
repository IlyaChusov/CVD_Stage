using System;
using System.Windows.Forms;

namespace Расчёт_ступени_ЦВД_паровой_турбины_2
{
    public partial class Form2 : Form
    {
        #region Переменные
        double h2, G, a1e, pi = Math.PI, h2_, uy, zy, dy, ddy, p0, v0, t0, t2t, p, noi1_, v2, z, ddy2, p02, v02, zy2, h2t2, z2, noi2_, v2t2, d11, u_c, dGy, G1, Hi1, ee, v1t, u1, p1, l, pк, a1e_, d1, d2, v22, b1, k, qt_1;
        int st, H01;        
        
        bool first = false;
        #endregion

        public Form2(double h2_, double G_)
        {
            InitializeComponent();
            h2 = h2_;
            G = G_;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            h2_ = Convert.ToDouble(in1.Text);
            uy = Convert.ToDouble(in2.Text);
            zy = Convert.ToDouble(in3.Text);
            dy = Convert.ToDouble(in4.Text);
            ddy = Convert.ToDouble(in5.Text);
            p0 = Convert.ToDouble(in6.Text);
            v0 = Convert.ToDouble(in7.Text);
            t0 = Convert.ToDouble(in35.Text);
            t2t = Convert.ToDouble(in36.Text);
            p = Convert.ToDouble(in8.Text);
            noi1_ = Convert.ToDouble(in9.Text);
            v2 = Convert.ToDouble(in10.Text);
            z = Convert.ToDouble(in11.Text);
            a1e = Convert.ToDouble(in12.Text);
            ddy2 = Convert.ToDouble(in13.Text);
            p02 = Convert.ToDouble(in14.Text);
            v02 = Convert.ToDouble(in15.Text);
            zy2 = Convert.ToDouble(in16.Text);
            h2t2 = Convert.ToDouble(in17.Text);
            z2 = Convert.ToDouble(in18.Text);
            noi2_ = Convert.ToDouble(in19.Text);
            v2t2 = Convert.ToDouble(in20.Text);
            d11 = Convert.ToDouble(in21.Text);
            u_c = Convert.ToDouble(in22.Text);
            v1t = Convert.ToDouble(in23.Text);
            u1 = Convert.ToDouble(in24.Text);
            p1 = Convert.ToDouble(in25.Text);
            l = Convert.ToDouble(in26.Text);
            pк = Convert.ToDouble(in27.Text);
            a1e_ = Convert.ToDouble(in28.Text);
            d1 = Convert.ToDouble(in29.Text);
            d2 = Convert.ToDouble(in30.Text);
            v22 = Convert.ToDouble(in31.Text);
            b1 = Convert.ToDouble(in32.Text);
            st = Convert.ToInt32(in33.Text);
            k = Convert.ToDouble(in34.Text);
            qt_1 = Convert.ToDouble(in37.Text);

            int H0_nreg = (int)Math.Round(h2 - h2_);
            out1.Text = H0_nreg.ToString();

            int H02;
            if (H0_nreg % 2 == 0)
            {
                H01 = H0_nreg / 2;
                H02 = H01;
            }
            else
            {
                H01 = H0_nreg / 2;
                H02 = H01 + 1;
            }
            out2.Text = H01.ToString();
            out3.Text = H02.ToString();

            double Fy = Math.Round((pi * dy * ddy) / 1000, 5);
            out4.Text = Fy.ToString();

            ee = Math.Round(p / p0, 3);
            out5.Text = ee.ToString();

            dGy = Math.Round(uy * Fy * Math.Sqrt((p0 * 1000000) / v0) * Math.Sqrt((1 - ee * ee) / zy), 2);
            out6.Text = dGy.ToString();

            G1 = Math.Round(G - dGy, 2);
            out7.Text = G1.ToString();

            double ccvc = Math.Round((1 / z) * Math.Pow(Math.Sin((a1e * pi) / 180), 2), 5);
            out8.Text = ccvc.ToString();

            Hi1 = Math.Round(H01 * noi1_, 3);
            out9.Text = Hi1.ToString();

            double noi1 = Math.Round((0.925 - (0.5 / (G1 * Math.Sqrt(v0 * v2)))) * (1 + ((H01 - 600) / 20000.0)) * (1 - ccvc), 2);
            out10.Text = noi1.ToString();

            first = true;
            
            while (Math.Abs(noi1 - noi1_) >= 0.01)
            {
                Form3 form3 = new Form3(first);
                form3.ShowDialog();
                if (form3.close == false)
                    break;
                v2 = form3.v2;
                noi1_ = Math.Round((0.925 - (0.5 / (G1 * Math.Sqrt(v0 * v2)))) * (1 + ((H01 - 600) / 20000.0)) * (1 - ccvc), 5);
                out10.Text = noi1_.ToString();
                Hi1 = Math.Round(H01 * noi1_, 3);
                out9.Text = Hi1.ToString();
                form3.close = false;
            }

            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double Fy2 = Math.Round((pi * dy * ddy2) / 1000, 5);
            out11.Text = Fy2.ToString();

            double dGy2 = Math.Round(uy * Fy2 * Math.Sqrt((p02 * 1000000) / v2) * Math.Sqrt((1 - Math.Pow(Math.Round(ee, 1), 2)) / zy2), 2);
            out12.Text = dGy2.ToString();

            double G2 = Math.Round(G1 + dGy - dGy2, 2);
            out13.Text = G2.ToString();

            double h02 = Math.Round(h2 - Hi1, 3);

            double H02_ = Math.Round(h02 - h2t2, 3);
            out14.Text = H02_.ToString();

            double ccvc2 = Math.Round((1 / z2) * Math.Pow(Math.Sin((a1e * pi) / 180), 2), 5);
            out15.Text = ccvc2.ToString();

            double noi2 = Math.Round((0.925 - (0.5 / (G2 * Math.Sqrt(v02 * v2t2)))) * (1 + ((H02_ - 600) / 20000.0)) * (1 - ccvc2), 5);
            out17.Text = noi2.ToString();

            double Hi2 = Math.Round(H02_ * noi2, 3);
            out16.Text = Hi2.ToString();

            bool form3close = false;
            while (Math.Abs(Math.Round(noi2, 3) - noi2_) >= 0.001)
            {
                form3close = false;
                first = false;
                Form3 form3 = new Form3(first);
                form3.ShowDialog();
                if (form3.close == false)
                    break;
                v2t2 = form3.v2;
                noi2_ = Math.Round((0.925 - (0.5 / (G2 * Math.Sqrt(v02 * v2t2)))) * (1 + ((H02_ - 600) / 20000.0)) * (1 - ccvc2), 3);
                out17.Text = noi2_.ToString();
                form3.close = false;
                form3close = true;
            }

            if (form3close == true)
            {
                double H01st = Math.Round(12.337 * (Math.Pow(d11, 2) / Math.Pow(u_c, 2)));
                out18.Text = H01st.ToString();

                double h2t1 = h2 - H01st;

                double pcp = Math.Round(pк + (1.7 / ((d11 / (l * 1000)) + 1.7)), 3);
                out19.Text = pcp.ToString();

                int n = 50;
                double l1 = Math.Round(((G1 * v1t * u_c) / (pi * pi * d11 * d11 * u1 * n * Math.Sqrt(1 - p1) * Math.Sin((a1e_ * pi) / 180))) * 1000, 1);
                out20.Text = l1.ToString();

                double l2 = Math.Round(l1 + d1 + d2, 1) / 1000;
                out21.Text = l2.ToString();

                double dк = Math.Round(d11 - l2, 4);
                out22.Text = dк.ToString();

                double Hi1st = Math.Round(H01st * noi1_, 3);
                out23.Text = Hi1st.ToString();

                double h21 = Math.Round(h2 - Hi1st, 3);
                out24.Text = h21.ToString();

                double l2z = Math.Round((-dк + Math.Sqrt(dк * dк - 4 * -(l2 * d11 * (v2 / v22)))) / 2, 6);
                out25.Text = l2z.ToString();

                double dz = Math.Round(dк + l2z, 4);
                out26.Text = dz.ToString();

                double f1 = Math.Round(0.98 - 0.008 * (b1 / l1), 4);
                out27.Text = f1.ToString();

                double u_cf1 = Math.Round((f1 * Math.Cos((a1e_ * pi) / 180)) / (2 * Math.Sqrt(1 - p1)), 4);
                out28.Text = u_cf1.ToString();

                double pz = Math.Round(1 - (1 - pк) * Math.Pow((dz / 2) / (dк / 2), -1.8), 4);
                out29.Text = pz.ToString();

                double f_posl = Math.Round(0.98 - 0.008 * (b1 / (l2z * 1000 - l / 10)), 4);
                out30.Text = f_posl.ToString();

                double u_cf_posl = Math.Round((f_posl * Math.Cos((a1e_ * pi) / 180)) / (2 * Math.Sqrt(1 - pz)), 4);
                out31.Text = u_cf_posl.ToString();

                double qt = Math.Round((1 - noi1_) * qt_1, 6);
                out38.Text = qt.ToString();

                Form4 form4 = new Form4(u_cf1, u_cf_posl, st, d11, dz, k, H01, qt);
                form4.Visible = true;

                double H0sr = 0;
                for (int i = 1; i <= st; i++)
                    H0sr += Convert.ToDouble(form4.array_H0[i]);
                H0sr = H0sr / st;
                out32.Text = H0sr.ToString();

                double T0 = t0 + 273.15;
                out33.Text = T0.ToString();

                double Tzt = t2t + 273.15;
                out34.Text = Tzt.ToString();

                double Tzt_T0_1 = Math.Round(Tzt / T0, 6);
                out35.Text = Tzt_T0_1.ToString();

                double Tzt_T0_2 = Math.Round(Math.Pow(p02 / p0, (1.3 - 1) / 1.3), 6);
                out36.Text = Tzt_T0_2.ToString();

                double Tzt_T0_sr = Math.Round((Tzt_T0_1 + Tzt_T0_2) / 2, 5);
                out37.Text = Tzt_T0_sr.ToString();

                double z = Math.Round((H01 * (1 + qt)) / H0sr);
                out39.Text = z.ToString();
            }
        }
    }
}