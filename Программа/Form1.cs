using System;
using System.Windows.Forms;

namespace Kurgasov01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            richTextBox1.Clear();
            switch (comboBox1.Text)
            {
                case "Технический":
                    comboBox2.Items.Add("Физика");
                    comboBox2.Items.Add("Математика");
                    comboBox2.Items.Add("Информатика");
                    break;
                case "Гуманитарный":
                    comboBox2.Items.Add("Творчество");
                    comboBox2.Items.Add("Работа с детьми");
                    comboBox2.Items.Add("Общество");
                    comboBox2.Items.Add("Лингвист");
                    break;
                case "Естественник":
                    comboBox2.Items.Add("Химия");
                    comboBox2.Items.Add("Биология");
                    comboBox2.Items.Add("Физическая культура");
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            richTextBox1.Clear();
            switch (comboBox2.Text)
            {
                case "Физика":
                    comboBox3.Items.Add("Электротехник");
                    break;
                case "Математика":
                    comboBox3.Items.Add("Металлург");
                    comboBox3.Items.Add("Инженер");
                    comboBox3.Items.Add("Программист-аналитик");
                    comboBox3.Items.Add("Геодезист");
                    break;
                case "Информатика":
                    comboBox3.Items.Add("Программист-аналитик");
                    comboBox3.Items.Add("Аналитик");
                    comboBox3.Items.Add("Программист-разработчик");
                    break;
                case "Творчество":
                    comboBox3.Items.Add("Художник");
                    comboBox3.Items.Add("Музыкант");
                    break;
                case "Работа с детьми":
                    comboBox3.Items.Add("Учитель");
                    comboBox3.Items.Add("Воспитатель");
                    break;
                case "Лингвист":
                    comboBox3.Items.Add("Лингвист");
                    break;
                case "Обществознание":
                    comboBox3.Items.Add("Аналитик");
                    comboBox3.Items.Add("Администратор");
                    comboBox3.Items.Add("Социальный работник");
                    comboBox3.Items.Add("Историк");
                    break;
                case "Химия":
                    comboBox3.Items.Add("Химик");
                    comboBox3.Items.Add("Металлург");
                    break;
                case "Биология":
                    comboBox3.Items.Add("Косметолог");
                    comboBox3.Items.Add("Врач");
                    break;
                case "Физическая культура":
                    comboBox3.Items.Add("Военный");
                    comboBox3.Items.Add("Спортсмен");
                    break;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            switch (comboBox3.Text)
            {
                case "Электротехник":
                    richTextBox1.Text = "Вам подходит специальность:\n- Электроэнергетика и электротехника(ЛГТУ)";
                    break;
                case "Металлург":
                    richTextBox1.Text = "Вам подходят специальности:\n- Материаловедение и технологии материалов(ЛГТУ)\n- Металлургия(ЛГТУ)";
                    break;
                case "Инженер":
                    richTextBox1.Text = "Вам подходят специальности:\n- Строительство(ЛГТУ)\n- Градостроительство(ЛГТУ)";
                    break;
                case "Программист-аналитик":
                    richTextBox1.Text = "Вам подходит специальность:\n- Прикладная математика(ЛГТУ)"; 
                    break;
                case "Геодезист":
                    richTextBox1.Text = "Вам подходит специальность:\n- Геодезист(СПБГУ)";
                    break;
                case "Аналитик":
                    richTextBox1.Text = "Вам подходит специальность:\n- Администрирование информационных систем(ЛГТУ)";
                    break;
                case "Программист-разработчик":
                    richTextBox1.Text = "Вам подходят специальности:\n- Информатика и вычислительная техника(ЛГТУ)\n- Администрирование информационных систем(ЛГТУ)\n- Программная инженерия(ЛГТУ)";
                    break;
                case "Художник":
                    richTextBox1.Text = "Вам подходят специальности:\n- Живопись(ЛГПУ)\n- Дизайнерство(ЛГТУ)";
                    break;
                case "Музыкант":
                    richTextBox1.Text = "Вам подходят специальности:\n- Пение(ВГИИ)\n- Пианино(ВГИИ)";
                    break;
                case "Учитель":
                    richTextBox1.Text = "Вам подходят специальности:\n- Учитель русского языка(ЛГПУ)\n- Учитель математики(ЛГПУ)\n- Учитель информатики(ЛГПУ)";
                    break;
                case "Воспитатель":
                    richTextBox1.Text = "Вам подходит специальность:\n- Учитель дошкольного образования(ЛГПУ)";
                    break;
                case "Лингвист":
                    richTextBox1.Text = "Вам подходит специальность:\n- Учитель иностранного языка(ЛГПУ)";
                    break;
                case "Администратор":
                    richTextBox1.Text = "Вам подходит специальность:\n- Управление персоналом(ЛГТУ)";
                    break;
                case "Социальный работник":
                    richTextBox1.Text = "Вам подходят специальности:\n- Психология(ЛГТУ)\n- Социология(ЛГТУ)";
                    break;
                case "Историк":
                    richTextBox1.Text = "Вам подходят специальности:\n- Правоохранительная деятельность(ИМВД)\n- Документоведение и архивоведение(ЛГТУ)";
                    break;
                case "Химик":
                    richTextBox1.Text = "Вам подходят специальности:\n- Химия(ЛГТУ)\n- Химическая технология(ЛГТУ)";
                    break;
                case "Косметолог":
                    richTextBox1.Text = "Вам подходит специальность:\n- Косметология(ФГБОУ)";
                    break;
                case "Врач":
                    richTextBox1.Text = "Вам подходят специальности:\n- Сестринское дело(ФГБОУ)\n- Медико-профилактическое дело(ФГБОУ)";
                    break;
                case "Военный":
                    richTextBox1.Text = "Вам подходят специальности:\n- Управление беспилотниками(ВУНЦ)\n- Военные науки(ВУНЦ)";
                    break;
                case "Спортсмен":
                    richTextBox1.Text = "Вам подходят специальности:\n- Рекреация(ЛГПУ)\n- Спорт(ЛГПУ)";
                    break;
            }
        }
    }
}
