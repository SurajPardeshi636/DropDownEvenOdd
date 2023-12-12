using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ArrayTask08Dec
{
    public partial class ArrayOddEvenFormate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)


        {
            if (!IsPostBack)
            {
               
                BindArrayList();
            }
        }

        private void BindArrayList()
        {
            List<int> numbers = new List<int>();

            for (int i = 1; i <= 100; i++)
            {
                numbers.Add(i);
            }

            DrpArrayList.DataSource = numbers;
            DrpArrayList.DataBind();
        }

        protected void DrpArrayList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //int selectedValue = Convert.ToInt32(DrpArrayList.SelectedValue);

            
            BindDropDownList2();

            
            BindDropDownList3();
        }

        private void BindDropDownList2()
        {
            List<int> evenNumbers = new List<int>();

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    evenNumbers.Add(i);
                }
            }

            DrpEven.DataSource = evenNumbers;
            DrpEven.DataBind();
        }

        private void BindDropDownList3()
        {
            List<int> oddNumbers = new List<int>();

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    oddNumbers.Add(i);
                }
            }

            DrpOdd.DataSource = oddNumbers;
            DrpOdd.DataBind();
        }
        
    }
}

//int[] numArray = new int[100];

//for (int i = 0; i< 100; i++)
//{
//    numArray[i] = i + 1;
//}