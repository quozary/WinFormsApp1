using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AutoRUApp
{
    public partial class MainForm : Form
    {
        // ������ �����������
        private List<Car> cars = new List<Car>();

        public MainForm()
        {
            InitializeComponent();
        }

        // ���������� ������ ���������� ����������
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            // �������� ������ � �����
            string make = txtMake.Text;
            string model = txtModel.Text;
            int year = (int)numYear.Value;
            decimal price = numPrice.Value;

            // ������� ����� ������ ����������
            Car newCar = new Car { Make = make, Model = model, Year = year, Price = price };

            // ��������� ��� � ������
            cars.Add(newCar);

            // ��������� ListBox
            UpdateCarList();
        }

        // ��������� ����������� ������ �����������
        private void UpdateCarList()
        {
            listBoxCars.Items.Clear(); // ������� ������� ������

            // ��������� ��� ���������� �� ������ � ListBox
            foreach (var car in cars)
            {
                listBoxCars.Items.Add(car);
            }
        }
    }
}

