using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerator
{
    class InsertIntoHistory
    {

        public static void Product(Connector con)
        {
            con.InsertInto("Product", "'Mleko 1,0%'", "1000", "1");
            con.InsertInto("Product", "'Mleko 2,0%'", "1000", "1");
            con.InsertInto("Product", "'Mleko 3,2%'", "1000", "1");

            con.InsertInto("Product", "'Gouda'", "1000", "2");
            con.InsertInto("Product", "'Gouda'", "500", "2");
            con.InsertInto("Product", "'Gouda'", "200", "2");
            con.InsertInto("Product", "'Salami'", "1000", "2");
            con.InsertInto("Product", "'Salami'", "500", "2");
            con.InsertInto("Product", "'Salami'", "200", "2");
            con.InsertInto("Product", "'Ementaler'", "1000", "2");
            con.InsertInto("Product", "'Ementaler'", "500", "2");
            con.InsertInto("Product", "'Ementaler'", "200", "2");
            con.InsertInto("Product", "'Plesniowy'", "500", "2");
            con.InsertInto("Product", "'Plesniowy'", "200", "2");

            con.InsertInto("Product", "'Danio Waniliowy'", "140", "3");
            con.InsertInto("Product", "'Danio Czekoladowy'", "140", "3");
            con.InsertInto("Product", "'Zott truskawkowy'", "200", "3");
            con.InsertInto("Product", "'Zott truskawkowy'", "500", "3");
            con.InsertInto("Product", "'Zott brzoskwiniowy'", "200", "3");
            con.InsertInto("Product", "'Zott brzoskwiniowy'", "500", "3");
            con.InsertInto("Product", "'Zott jagodowy'", "200", "3");
            con.InsertInto("Product", "'Zott jagodowy'", "500", "3");

            con.InsertInto("Product", "'Cisowianka NGaz'", "500", "4");
            con.InsertInto("Product", "'Cisowianka NGaz'", "1500", "4");
            con.InsertInto("Product", "'Naleczowianka NGaz'", "500", "4");
            con.InsertInto("Product", "'Naleczowianka NGaz'", "1500", "4");
            con.InsertInto("Product", "'Staropolanka NGaz'", "500", "4");
            con.InsertInto("Product", "'Staropolanka NGaz'", "1500", "4");
            con.InsertInto("Product", "'Zywiec Zdroj NGaz'", "500", "4");
            con.InsertInto("Product", "'Zywiec Zdroj NGaz'", "1500", "4");

            con.InsertInto("Product", "'Cisowianka Gaz'", "500", "4");
            con.InsertInto("Product", "'Cisowianka Gaz'", "1500", "4");
            con.InsertInto("Product", "'Naleczowianka Gaz'", "500", "4");
            con.InsertInto("Product", "'Naleczowianka Gaz'", "1500", "4");
            con.InsertInto("Product", "'Staropolanka Gaz'", "500", "4");
            con.InsertInto("Product", "'Staropolanka Gaz'", "1500", "4");
            con.InsertInto("Product", "'Zywiec Zdroj Gaz'", "500", "4");
            con.InsertInto("Product", "'Zywiec Zdroj Gaz'", "1500", "4");

            con.InsertInto("Product", "'Coca Cola'", "500", "5");
            con.InsertInto("Product", "'Coca Cola'", "1500", "5");
            con.InsertInto("Product", "'Sprite'", "500", "5");
            con.InsertInto("Product", "'Sprite'", "1500", "5");
            con.InsertInto("Product", "'Fanta'", "500", "5");
            con.InsertInto("Product", "'Fanta'", "1500", "5");
            con.InsertInto("Product", "'Mirinda'", "500", "5");
            con.InsertInto("Product", "'Mirinda'", "1500", "5");
            con.InsertInto("Product", "'Lift jablkowy'", "500", "5");
            con.InsertInto("Product", "'Lift jablkowy'", "1500", "5");

            con.InsertInto("Product", "'Cappy jablkowy'", "330", "6");
            con.InsertInto("Product", "'Cappy jablkowy'", "1000", "6");
            con.InsertInto("Product", "'Cappy pomaranczowy'", "330", "6");
            con.InsertInto("Product", "'Cappy pomaranczowy'", "1000", "6");
            con.InsertInto("Product", "'Cappy wieloowocowy'", "330", "6");
            con.InsertInto("Product", "'Cappy wieloowocowy'", "1000", "6");
            con.InsertInto("Product", "'Tymbark jabklo-mieta'", "500", "6");
            con.InsertInto("Product", "'Tymbark jabklo-mieta'", "2000", "6");
            con.InsertInto("Product", "'Tymbark jabklo-wisnia'", "500", "6");
            con.InsertInto("Product", "'Tymbark jabklo-wisnia'", "2000", "6");
            con.InsertInto("Product", "'Tymbark jabklo100%'", "500", "6");
            con.InsertInto("Product", "'Tymbark jabklo100%'", "2000", "6");


            con.InsertInto("Product", "'Milka biala'", "100", "7");
            con.InsertInto("Product", "'Milka deserowa'", "100", "7");
            con.InsertInto("Product", "'Milka truskawkowa'", "100", "7");
            con.InsertInto("Product", "'Milka mleczna'", "100", "7");
            con.InsertInto("Product", "'Wedel gorzka'", "100", "7");
            con.InsertInto("Product", "'Wedel deserowa'", "100", "7");
            con.InsertInto("Product", "'Wedel morelowa'", "100", "7");
            con.InsertInto("Product", "'Wedel truskawkowa'", "100", "7");
            con.InsertInto("Product", "'Wedel karmelowa'", "100", "7");

            con.InsertInto("Product", "'Snickers'", "32", "8");
            con.InsertInto("Product", "'Snickers'", "65", "8");
            con.InsertInto("Product", "'Mars'", "32", "8");
            con.InsertInto("Product", "'Mars'", "65", "8");
            con.InsertInto("Product", "'Twix'", "32", "8");
            con.InsertInto("Product", "'Twix'", "65", "8");
            con.InsertInto("Product", "'Kitkat'", "32", "8");
            con.InsertInto("Product", "'Kitkat'", "65", "8");
            con.InsertInto("Product", "'Prince polo XXL'", "50", "8");
            con.InsertInto("Product", "'Grzeski'", "50", "8");
            con.InsertInto("Product", "'Grzeski toffi'", "50", "8");

            con.InsertInto("Product", "'Lindt'", "100", "9");
            con.InsertInto("Product", "'Wedel'", "100", "9");
            con.InsertInto("Product", "'Rafaello'", "100", "9");
            con.InsertInto("Product", "'Ferrero roche'", "100", "9");

            con.InsertInto("Product", "'Sarmackie'", "500", "10");
            con.InsertInto("Product", "'Zubr zloty'", "500", "10");
            con.InsertInto("Product", "'Zubr'", "500", "10");
            con.InsertInto("Product", "'Tyskie'", "500", "10");
            con.InsertInto("Product", "'Zywiec'", "500", "10");
            con.InsertInto("Product", "'Zywiec bialy'", "500", "10");
            con.InsertInto("Product", "'Carlsberg'", "500", "10");
            con.InsertInto("Product", "'Debowe mocne'", "500", "10");

            con.InsertInto("Product", "'Lubelska czysta'", "100", "11");
            con.InsertInto("Product", "'Lubelska czysta'", "200", "11");
            con.InsertInto("Product", "'Lubelska czysta'", "500", "11");
            con.InsertInto("Product", "'Lubelska czysta'", "700", "11");
            con.InsertInto("Product", "'Smirnoff czysta'", "100", "11");
            con.InsertInto("Product", "'Smirnoff czysta'", "200", "11");
            con.InsertInto("Product", "'Smirnoff czysta'", "500", "11");
            con.InsertInto("Product", "'Smirnoff czysta'", "700", "11");
            con.InsertInto("Product", "'Wyborowa czysta'", "100", "11");
            con.InsertInto("Product", "'Wyborowa czysta'", "200", "11");
            con.InsertInto("Product", "'Wyborowa czysta'", "500", "11");
            con.InsertInto("Product", "'Wyborowa czysta'", "700", "11");
        }

        public static void Employees(Connector con)
        {
            con.InsertInto("Employee", "'Jan'", "'Kowalski'", "1980");
            con.InsertInto("Employee", "'Janina'", "'Kowalska'", "1981");
            con.InsertInto("Employee", "'Krzysztof'", "'Holowczyc'", "1989");
            con.InsertInto("Employee", "'Robert'", "'Lewandowski'", "1985");
            con.InsertInto("Employee", "'Anna'", "'Lewandowska'", "1985");
            con.InsertInto("Employee", "'Sebastian'", "'Mila'", "1975");
            con.InsertInto("Employee", "'Krystyna'", "'Pawlowska'", "1965");
            con.InsertInto("Employee", "'Piotr'", "'Zielinski'", "1987");
            con.InsertInto("Employee", "'Kamil'", "'Glik'", "1984");
            con.InsertInto("Employee", "'Arek'", "'Milik'", "1994");
            con.InsertInto("Employee", "'Kamil'", "'Grosicki'", "1986");
            con.InsertInto("Employee", "'Diego'", "'Costa'", "1984");
            con.InsertInto("Employee", "'Thomas'", "'Muller'", "1986");
        }

        public static void Moth(Connector con)
        {
            for (int i = 1; i <= 12; i++)
            {
                con.InsertInto("Month", i.ToString());
            }
        }

        public static object[,] FactArray()
        {
            object[,] myArray = new object[,]
            {
                {4, 2.99},
                {5, 2.99},
                {6, 2.99},
                {7, 29.90},
                {8, 20.99},
                {9, 4.99},
                {10, 33.99},
                {11, 22.99},
                {12, 7.99},
                {13, 38.99},
                {14, 29.99},
                {15, 8.99},
                {16, 16.99},
                {17, 8.99},
                {18, 1.49},
                {19, 1.49},
                {20, 1.59},
                {21, 2.99},
                {22, 1.59},
                {23, 2.99},
                {24, 1.59},
                {25, 2.99},
                {26, 0.99},
                {27, 1.99},
                {28, 0.99},
                {29, 1.99},
                {30, 1.19},
                {31, 1.99},
                {32, 1.29},
                {33, 2.39},
                {34, 0.99},
                {35, 1.99},
                {36, 0.99},
                {37, 1.99},
                {38, 1.19},
                {39, 1.99},
                {40, 1.39},
                {41, 2.39},
                {42, 2.59},
                {43, 4.99},
                {44, 2.59},
                {45, 4.99},
                {46, 2.59},
                {47, 4.99},
                {48, 2.59},
                {49, 4.99},
                {50, 0.99},
                {51, 2.99},
                {52, 1.99},
                {53, 3.99},
                {54, 1.99},
                {55, 3.99},
                {56, 1.99},
                {57, 3.99},
                {58, 1.99},
                {59, 4.49},
                {60, 1.99},
                {61, 4.49},
                {62, 1.99},
                {63, 4.49},
                {64, 3.19},
                {65, 3.19},
                {66, 3.29},
                {67, 3.19},
                {68, 2.99},
                {69, 3.19},
                {70, 3.19},
                {71, 3.19},
                {72, 3.19},
                {73, 1.49},
                {74, 1.99},
                {75, 1.49},
                {76, 1.99},
                {77, 1.49},
                {78, 1.99},
                {79, 1.49},
                {80, 1.99},
                {81, 1.49},
                {82, 1.49},
                {83, 1.59},
                {84, 20.99},
                {85, 12.99},
                {86, 13.99},
                {87, 19.99},
                {88, 1.29},
                {89, 1.99},
                {90, 1.89},
                {91, 1.99},
                {92, 1.99},
                {93, 2.99},
                {94, 2.29},
                {95, 2.29},
                {96, 6.99},
                {97, 10.99},
                {98, 17.99},
                {99, 22.99},
                {100, 10.99},
                {101, 16.99},
                {102, 25.99},
                {103, 35.99},
                {104, 8.99},
                {105, 13.99},
                {106, 23.99},
                {107, 28.99}
            };

            return myArray;
        }

    }
}
