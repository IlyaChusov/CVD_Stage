using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace Расчёт_ступени_ЦВД_паровой_турбины_2
{
    public partial class Form4 : Form
    {
        private ZedGraphControl z1;
        double u_cf1;
        double u_cf_posl;
        double help1;
        double help2;
        int st;
        double d;
        double dz;
        double k;
        public string[] array_H0;
        int H01;
        double qt;

        public Form4(double u_cf1_, double u_cf_posl_, int st_, double d_, double dz_, double k_, int H01_, double qt_)
        {
            InitializeComponent();
            u_cf1 = u_cf1_;
            u_cf_posl = u_cf_posl_;
            st = st_;
            d = d_;
            dz = dz_;
            k = k_;
            help1 = (u_cf_posl - u_cf1) / (st - 1);
            help2 = (dz - d) / (st - 1);
            H01 = H01_;
            qt = qt_;
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            GraphPane paneD = z2.GraphPane;
            GraphPane paneU = z1.GraphPane;
            GraphPane paneH0_ = z3.GraphPane;
            GraphPane paneH0 = z4.GraphPane;
            paneD.CurveList.Clear();
            paneU.CurveList.Clear();
            paneH0_.CurveList.Clear();
            paneH0.CurveList.Clear();

            paneD.Title.Text = "d";
            paneU.Title.Text = "u_cf_opt";
            paneH0_.Title.Text = "H0_";
            paneH0.Title.Text = "H0";
            paneD.XAxis.Title.Text = "";
            paneD.YAxis.Title.Text = "";
            paneU.XAxis.Title.Text = "";
            paneU.YAxis.Title.Text = "";
            paneH0_.XAxis.Title.Text = "";
            paneH0_.YAxis.Title.Text = "";
            paneH0.XAxis.Title.Text = "";
            paneH0.YAxis.Title.Text = "";

            PointPairList list_D = new PointPairList();
            PointPairList list_U = new PointPairList();
            PointPairList list_H0_ = new PointPairList();
            PointPairList list_H0 = new PointPairList();

            string[] array_D = new string[st + 1];
            string[] array_U = new string[st + 1];
            string[] array_H0_ = new string[st + 1];

            array_H0 = new string[st + 1];
            string[] arrayH0__ = new string[st + 2];
            string[] arrayH0dd = new string[st + 2];
            table.ColumnCount = st + 1;
            table2.ColumnCount = st + 2;
            table.Columns[0].Name = "x";
            table2.Columns[0].Name = "№ ступени";

            double sumH0 = 0;
            for (int i = 1; i <= st; i++)
            {
                table.Columns[i].Name = i.ToString();
                table2.Columns[i].Name = i.ToString();
                array_D[i] = D_table(i).ToString();
                array_U[i] = U_table(i).ToString();
                array_H0_[i] = _H0_table(D_table(i), U_table(i)).ToString();
                array_H0[i] = H0_table(_H0_table(D_table(i), U_table(i))).ToString();
                array_H0[1] = array_H0_[1];
                sumH0 += Convert.ToDouble(array_H0[i]);
                list_D.Add(i, U_table(i));
                list_U.Add(i, D_table(i));
                list_H0_.Add(i, _H0_table(D_table(i), U_table(i)));
                if (i != 1)
                   list_H0.Add(i, H0_table(_H0_table(D_table(i), U_table(i))));
                else
                    list_H0.Add(i, _H0_table(D_table(i), U_table(i)));
            }

            arrayH0__[st + 1] = sumH0.ToString();

            array_D[0] = "d";
            array_U[0] = "u_cf_opt";
            array_H0_[0] = "H0_";
            array_H0[0] = "H0";
            arrayH0dd[0] = "H0 + d / 5";
            table2.Columns[st + 1].Name = "Сумма H0";

            double sumH0_ = Math.Round(H01 * (1 + qt), 3);
            double dd = Math.Round(Math.Abs(sumH0 - sumH0_), 3) / 5.0;
            out1.Text = sumH0_.ToString();
            out2.Text = (dd * 5).ToString();
            out3.Text = Math.Round(dd, 5).ToString();

            array_H0.CopyTo(arrayH0__, 0);
            double sumH0_d = 0;
            for (int i = 1; i <= st; i++)
            {
                arrayH0dd[i] = Math.Round((Convert.ToDouble(arrayH0__[i]) + dd), 3).ToString();
                sumH0_d += Convert.ToDouble(arrayH0dd[i]);
            }

            arrayH0dd[st + 1] = sumH0_d.ToString();

            table.Rows.Add(array_D);
            table.Rows.Add(array_U);
            table.Rows.Add(array_H0_);
            table.Rows.Add(array_H0);
            table2.Rows.Add(arrayH0__);
            table2.Rows.Add(arrayH0dd);
            LineItem Curve_D = paneU.AddCurve("", list_D, Color.Blue);
            LineItem Curve_U = paneD.AddCurve("", list_U, Color.Red);
            LineItem Curve_H0_ = paneH0_.AddCurve("", list_H0_, Color.Green);
            LineItem Curve_H0 = paneH0.AddCurve("", list_H0, Color.Black);
            
            paneD.IsBoundedRanges = true;
            paneU.IsBoundedRanges = true;
            paneH0_.IsBoundedRanges = true;
            paneH0.IsBoundedRanges = true;

            z1.AxisChange();
            z2.AxisChange();
            z3.AxisChange();
            z4.AxisChange();
        }

        double U_table(int x)
        {
            return Math.Round(help1 * x + 0.4877 - help1, 5);
        }

        double D_table(int x)
        {
            return Math.Round(help2 * x + 0.9 - help2, 5);
        }

        double _H0_table(double d, double u_cf)
        {
            return Math.Round(12.337 * Math.Pow(d / u_cf, 2), 3);
        }

        double H0_table(double H0)
        {
            return Math.Round(k * H0, 3);
        }
     }
}