using GenericListRegist.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Windows;
using System.IO;
using System.Collections;

namespace GenericListRegist
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }
        List<Register> list;
        private void btnsave_Click(object sender, RoutedEventArgs e)
        {
            //Stack<Register> stack = new Stack<Register>();
            //Queue<Register> que = new Queue<Register>();
            if (list is null)
            {
                list = new List<Register>();
            }
            Register register = new Register();
            register.Name = txtname.Text;
            register.Password = txtpassword.Text;
            register.Email = txtemail.Text;
            register.Contact = Convert.ToInt32(txtcontact.Text);
            register.Age = Convert.ToInt32(txtage.Text);
            register.Address = txtaddress.Text;
            list.Add(register);
            foreach (var item in list)
            {
                lstbox.Items.Add(item.Name);
                lstbox.Items.Add(item.Password);
                lstbox.Items.Add(item.Age);
                lstbox.Items.Add(item.Email);
                lstbox.Items.Add(item.Address);
                lstbox.Items.Add(item.Contact);
            }
            


            //list.Add(txtname.Text);
            //list.Add(txtpassword.Text);
            //list.Add(txtage.Text);
            //list.Add(txtcontact.Text);
            //list.Add(txtemail.Text);
            //list.Add(txtaddress.Text);
            //lstbox.ItemsSource = null;
            //lstbox.ItemsSource = list;

            //stack.Push(register);
            //que.Enqueue(register);

            cmbhash.Items.Add(txtname.Text);



            //string[] value=File.ReadAllLines(txtname.Text);
            //ArrayList arrayList = new ArrayList();
            //foreach (string s in value)
            //{
            //    arrayList.Add(value);
            //    cmbhash.ItemsSource = null;
            //    cmbhash.ItemsSource = arrayList;
            //}
        }
       
    }
}
