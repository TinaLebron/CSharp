using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] arrayBentoName = new string[11];
            int[] arrayBentoPrice = new int[10];
            int price = 0;

            //���
            arrayBentoName[0] = "1. ���������L�K��";
            arrayBentoName[1] = "2. �������ޱƫK��";
            arrayBentoName[2] = "3. ���ά�M���K��";
            arrayBentoName[3] = "4. �������L�K��";
            arrayBentoName[4] = "5. �����ư��K��";
            arrayBentoName[5] = "6. �����e�����L�K��";
            arrayBentoName[6] = "7. ���z�Ϧ׫K��";
            arrayBentoName[7] = "8. �_�������K��";
            arrayBentoName[8] = "9. �M�H�i�������K��";
            arrayBentoName[9] = "10. �h���׫p���ƫK��";
            arrayBentoName[10] = "Q. ���p�߫������a�����}";

            //����
            arrayBentoPrice[0] = 85;
            arrayBentoPrice[1] = 80;
            arrayBentoPrice[2] = 75;
            arrayBentoPrice[3] = 85;
            arrayBentoPrice[4] = 80;
            arrayBentoPrice[5] = 85;
            arrayBentoPrice[6] = 80;
            arrayBentoPrice[7] = 85;
            arrayBentoPrice[8] = 85;
            arrayBentoPrice[9] = 100;
            
            //�]�p�L�a�j�骺�߰�, ���n�i�H�����{��

            while (true) {

                Console.WriteLine("�w����{~�p�L�K�����t��~\n");
                Console.WriteLine("������榳:");

                for (int i = 0; i < arrayBentoName.Length; i++) {
                    Console.WriteLine("\n" + arrayBentoName[i] + " ");
                }

                Console.WriteLine("\n�I�\���覡�A�п�J���s��:\n");

                string strSearchForLunch = Console.ReadLine();

                if (strSearchForLunch != "Q") {

                    ClickMenu(strSearchForLunch, arrayBentoName, arrayBentoPrice, price);
                    
                    Console.WriteLine("\n�˷R���Ȥ�еy���A���W���z�e�W�����˪����a ^__^ \n");
                    Console.WriteLine("*********************************************************************\n");
                    Console.WriteLine("�˷R���Ȥ�p�G�ݭn�b�I�\�A�бz���U \"enter\"");
                    Console.WriteLine("\n�˷R���Ȥ�p�G�n���}�I�\�ϡA�Ы��U \"Q\"");
                    Console.WriteLine("\n*********************************************************************\n");

                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    break;
                }
            }

        }
        //�Ȥ��ܵ�檺����O
        public static void ClickMenu(string strSearchForLunch, string[] arrayBentoName,int[] arrayBentoPrice,int price)
        {
            switch (strSearchForLunch)
            {
                case "1":
                    strSearchForLunch = arrayBentoName[0];
                    price = arrayBentoPrice[0];
                    break;
                case "2":
                    strSearchForLunch = arrayBentoName[1];
                    price = arrayBentoPrice[1];
                    break;
                case "3":
                    strSearchForLunch = arrayBentoName[2];
                    price = arrayBentoPrice[2];
                    break;
                case "4":
                    strSearchForLunch = arrayBentoName[3];
                    price = arrayBentoPrice[3];
                    break;
                case "5":
                    strSearchForLunch = arrayBentoName[4];
                    price = arrayBentoPrice[4];
                    break;
                case "6":
                    strSearchForLunch = arrayBentoName[5];
                    price = arrayBentoPrice[5];
                    break;
                case "7":
                    strSearchForLunch = arrayBentoName[6];
                    price = arrayBentoPrice[6];
                    break;
                case "8":
                    strSearchForLunch = arrayBentoName[7];
                    price = arrayBentoPrice[7];
                    break;
                case "9":
                    strSearchForLunch = arrayBentoName[8];
                    price = arrayBentoPrice[8];
                    break;
                case "10":
                    strSearchForLunch = arrayBentoName[9];
                    price = arrayBentoPrice[9];
                    break;
                case "Q":
                    break;
                default:
                    strSearchForLunch = "�L�����A�бx���������A�Цb���s�I�\";
                    price = 0;
                    break;
            }
            Console.WriteLine("\n�z�ҿ�ܪ��K��: " + strSearchForLunch + "�A�����欰: " + price);
        }
    }
}
