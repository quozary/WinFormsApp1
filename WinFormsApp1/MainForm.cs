using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AutoRUApp
{
    public partial class MainForm : Form
    {
        // Список автомобилей
        private List<Car> cars = new List<Car>();

        public MainForm()
        {
            InitializeComponent();
        }

        // Обработчик кнопки добавления автомобиля
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            // Получаем данные с формы
            string make = txtMake.Text;
            string model = txtModel.Text;
            int year = (int)numYear.Value;
            decimal price = numPrice.Value;

            // Создаем новый объект автомобиля
            Car newCar = new Car { Make = make, Model = model, Year = year, Price = price };

            // Добавляем его в список
            cars.Add(newCar);

            // Обновляем ListBox
            UpdateCarList();
        }

        // Обновляем отображение списка автомобилей
        private void UpdateCarList()
        {
            listBoxCars.Items.Clear(); // Очищаем текущий список

            // Добавляем все автомобили из списка в ListBox
            foreach (var car in cars)
            {
                listBoxCars.Items.Add(car);
            }
        }
    }
}

