using System;
using System.Windows.Forms;

/**
 * 策略模式：
 *      它定义了算法家族，分别封装起来，让他们之间可以相互替换，此模式让算法的变化，
 *      不会影响到使用算法的客户。
 */
namespace StrategyModel
{
    public partial class Form1 : Form
    {
        double total = 0.0d;

        public Form1()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            CashContext csuper = new CashContext(calculate_method.SelectedItem.ToString());
            double totalPrices = 0d;
            totalPrices = csuper.GetResult(Convert.ToDouble(text_price.Text) * Convert.ToDouble(text_num.Text));
            total += totalPrices;

            goodsList.Items.Add("单价：" + text_price.Text + " 数量：" + text_num.Text + " 合计：" + totalPrices);
            label_result.Text = total.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calculate_method.Items.Add("正常收费");
            calculate_method.Items.Add("满 300 返 100");
            calculate_method.Items.Add("打 8 折");
            calculate_method.SelectedIndex = 0;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            goodsList.Items.Clear();
            label_result.Text = (total = 0).ToString();
        }
    }

    public abstract class CashSuper
    {
        public abstract double acceptCash(double money);
    }

    public class CashNormal : CashSuper
    {
        public override double acceptCash(double money)
        {
            return money;
        }
    }

    public class CashRebate : CashSuper
    {
        private double moneyRebate = 1d;

        public CashRebate(String moneyRebate)
        {
            this.moneyRebate = double.Parse(moneyRebate);
        }

        public override double acceptCash(double money)
        {
            return money * moneyRebate;
        }
    }

    public class CashReturn : CashSuper
    {
        private double moneyCondition = 0.0d;
        private double moneyReturn = 0.0d;

        public CashReturn(String moneyCondition, String moneyReturn)
        {
            this.moneyCondition = double.Parse(moneyCondition);
            this.moneyReturn = double.Parse(moneyReturn);
        }

        public override double acceptCash(double money)
        {
            return 0d;
        }
    }

    public class CashContext
    {
        private CashSuper cs = null;

        public CashContext(String type)
        {
            switch (type)
            {
                case "正常收费":
                    cs = new CashNormal();
                    break;
                case "满 300 返 100":
                    cs = new CashReturn("300", "100");
                    break;
                case "打 8 折":
                    cs = new CashRebate("0.8");
                    break;
            }
        }

        public double GetResult(double money)
        {
            return cs.acceptCash(money);
        }
    }

}
