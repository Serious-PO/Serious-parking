using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Terminal
{
    class Test
    {
        private Form_operator form_operator;
        private Form_add_user form_add_user;
        private Form_change_price form_change_price;
        private bool test=false; 

        public Test(Form_operator form_operator_cons)
        {
            if (test == true)
            {
                form_operator = form_operator_cons;
                form_operator_cons_true();
                form_operator_cons_false_car_num();
                form_operator_cons_false_car();
                form_operator_cons_false_add_money();
            }
        }
        public Test(Form_add_user form_add_user_cons)
        {
            if (test == true)
            {
                form_add_user = form_add_user_cons;
                add_user_test_true();
                add_user_test_false_date();
                add_user_test_false_car();
                add_user_test_false_bd();
                add_user_test_false_phone_num();
            }

        }
        public Test(Form_change_price form_change_price_cons)
        {
            if (test == true)
            {
                form_change_price = form_change_price_cons;
                form_change_price_true();
                form_change_price_false_price();
                form_change_price_false_pas();
            }
        }

        private void add_user_test_true()
        {
            form_add_user.textBox_last_name.Text = "Ивнов";
            form_add_user.textBox_first_name.Text = "Иван";
            form_add_user.textBox_day.Text = "1";
            form_add_user.textBox_month.Text = "1";
            form_add_user.textBox_year.Text = "2000";
            form_add_user.textBox_carNumber1.Text = "B";
            form_add_user.textBox_carNumber2.Text = "454";
            form_add_user.textBox_carNumber3.Text = "КЕ";
            form_add_user.text_telephone.Text = "89566545819";
            form_add_user.testLeft = true;
            form_add_user.button_apply.PerformClick();
        }
        private void add_user_test_false_date()
        {
            form_add_user.textBox_last_name.Text = "Ивнов";
            form_add_user.textBox_first_name.Text = "Иван";
            form_add_user.textBox_day.Text = "33";
            form_add_user.textBox_month.Text = "1";
            form_add_user.textBox_year.Text = "2000";
            form_add_user.textBox_carNumber1.Text = "A";
            form_add_user.textBox_carNumber2.Text = "454";
            form_add_user.textBox_carNumber3.Text = "КЕ";
            form_add_user.text_telephone.Text = "89566545819";
            form_add_user.testLeft = true;
            form_add_user.button_apply.PerformClick();
        }
        private void add_user_test_false_car()
        {
            form_add_user.textBox_last_name.Text = "Ивнов";
            form_add_user.textBox_first_name.Text = "Иван";
            form_add_user.textBox_day.Text = "1";
            form_add_user.textBox_month.Text = "1";
            form_add_user.textBox_year.Text = "2000";
            form_add_user.textBox_carNumber1.Text = "AB";
            form_add_user.textBox_carNumber2.Text = "45";
            form_add_user.textBox_carNumber3.Text = "КЕR";
            form_add_user.text_telephone.Text = "89566545819";
            form_add_user.testLeft = true;
            form_add_user.button_apply.PerformClick();
        }

        private void add_user_test_false_bd()
        {
            form_add_user.textBox_last_name.Text = "Ивнов";
            form_add_user.textBox_first_name.Text = "Иван";
            form_add_user.textBox_day.Text = "1";
            form_add_user.textBox_month.Text = "1";
            form_add_user.textBox_year.Text = "2000";
            form_add_user.textBox_carNumber1.Text = "A";
            form_add_user.textBox_carNumber2.Text = "732";
            form_add_user.textBox_carNumber3.Text = "PE";
            form_add_user.text_telephone.Text = "89566545819";
            form_add_user.testLeft = true;
            form_add_user.button_apply.PerformClick();
        }
        private void add_user_test_false_phone_num()
        {
            form_add_user.textBox_last_name.Text = "Ивнов";
            form_add_user.textBox_first_name.Text = "Иван";
            form_add_user.textBox_day.Text = "1";
            form_add_user.textBox_month.Text = "1";
            form_add_user.textBox_year.Text = "2000";
            form_add_user.textBox_carNumber1.Text = "A";
            form_add_user.textBox_carNumber2.Text = "454";
            form_add_user.textBox_carNumber3.Text = "KE";
            form_add_user.text_telephone.Text = "895665458199";
            form_add_user.testLeft = true;
            form_add_user.button_apply.PerformClick();
        }



        private void form_operator_cons_true()
        {
            form_operator.textBox_carNumber1.Text = "A";
            form_operator.textBox_carNumber2.Text = "732";
            form_operator.textBox_carNumber3.Text = "PE";
            form_operator.textBox_money.Text = "100";
            form_operator.button_apply_balance.PerformClick();
        }
           private void form_operator_cons_false_car_num()
        {
            form_operator.textBox_carNumber1.Text = "A";
            form_operator.textBox_carNumber2.Text = "486";
            form_operator.textBox_carNumber3.Text = "PE";
            form_operator.textBox_money.Text = "100";
            form_operator.button_apply_balance.PerformClick();
        }
           private void form_operator_cons_false_car()
           {
               form_operator.textBox_carNumber1.Text = "ASD";
               form_operator.textBox_carNumber2.Text = "720";
               form_operator.textBox_carNumber3.Text = "PE";
               form_operator.textBox_money.Text = "100";
               form_operator.button_apply_balance.PerformClick();
           }
           private void form_operator_cons_false_add_money()
           {
               form_operator.textBox_carNumber1.Text = "A";
               form_operator.textBox_carNumber2.Text = "720";
               form_operator.textBox_carNumber3.Text = "PE";
               form_operator.textBox_money.Text = "-500";
               form_operator.button_apply_balance.PerformClick();
           }


           private void form_change_price_true()
           {
               form_change_price.textBox_password.Text = "123456";
               form_change_price.textBox_price.Text = "10";
               form_change_price.button1.PerformClick();
           }
           private void form_change_price_false_price()
           {
               form_change_price.textBox_password.Text = "123456";
               form_change_price.textBox_price.Text = "-10";
               form_change_price.button1.PerformClick();
           }
           private void form_change_price_false_pas()
           {
               form_change_price.textBox_password.Text = "12345";
               form_change_price.textBox_price.Text = "10";
               form_change_price.button1.PerformClick();
           }

    }
    
}
