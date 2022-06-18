using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Data
    {
        public string nam = "fy";
        // I have to define to variables
        // In this page we have different arrays one of them for customers informations
        // The other array for our product information
        // The first array is the customers. We have string variables in here. 
        // We have customer name, surname, id, phone and e-mail
        public string[,] customers = {
            { "Feyza", "Yılmaz", "01234569874", "545 100 00 00", "feyza.yilmaz01@mlia.com" },
            { "Cem", "Tiryaki", "02234569874", "545 200 00 00", "cem.tiyaki02@mlia.com" },
            { "Vito", "Konuk", "03234569874", "545 300 00 00", "vito.konuk03@mlia.com" },
            { "Afra", "Yılmaz", "04234569874", "545 400 00 00", "afra.yilmaz04@mlia.com" },
            { "Şevval", "Çetin", "05234569874", "545 500 00 00", "sevval.cetin05@mlia.com" }
            //name,     surname,      id,         phone,         email
        };

        // The second array is the products. We have int variables in here.
        // We have product nameid, price, quantity and volorid in here.
        public int[,] products = {
            {100, 545, 50, 01 },
            {101, 200, 45, 02 },
            {102, 250, 30, 02 },
            {103, 349, 15, 03 },
            {104, 650, 20, 05 },
            {105, 449, 01, 04 }
        //nameid,price,quantity,colorid
        };
        
    }
}
