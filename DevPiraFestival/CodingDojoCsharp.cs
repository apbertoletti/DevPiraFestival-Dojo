using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevPiraFestival
{
    [TestClass]
    public class CodingDojoCsharp
    {
        //Dictionary<int, string> nDiv= new Dictionary<int, string>();

        [TestMethod]
        public void Quando_Passar_1_Retorna_1()
        {
            //1) prepara o teste
            string r;

            //2) executa o teste
            r = FizzBuzz(1);

            //3) verifica o teste
            Assert.AreEqual("1", r);
        }

        [TestMethod]
        public void Quando_Passar_Numeros_Divisiveis_Por_3_Retorna_Fizz()
        {
            //1) prepara o teste
            var inputs = new int[] { 3, 6, 9, 12 };
            string r;
            foreach (int testar in inputs)
            {
                //2) executa o teste
                r = FizzBuzz(testar);

                //3) verifica o teste
                Assert.AreEqual("Fizz", r);
            }
        }

        [TestMethod]
        public void Quando_Passar_Numeros_Divisiveis_Por_5_Retorna_Buzz()
        {
            //1) prepara o teste
            var inputs = new int[] { 5, 10, 85, 100 };
            string r;
            foreach (int testar in inputs)
            {
                //2) executa o teste
                r = FizzBuzz(testar);

                //3) verifica o teste
                Assert.AreEqual("Buzz", r);
            }
        }

        [TestMethod]
        public void Quando_Passar_Numeros_15_Retorna_FizzBuzz()
        {
            //1) prepara o teste
            var expected = "FizzBuzz";
            var inputs = 15;
            string r;

            //2) executa o teste
            r = FizzBuzz(inputs);

            //3) verifica o teste
            Assert.AreEqual(expected, r);
        }

        [TestMethod]
        public void Quando_Passar_2_retorna_2()
        {
            //1) prepara o teste
            var expected = "2";
            var inputs = 2;
            string r;

            //2) executa o teste
            r = FizzBuzz(inputs);

            //3) verifica o teste
            Assert.AreEqual(expected, r);
        }

        [TestMethod]
        public void Quando_Passar_1_nao_retorna_Fizz()
        {
            //1) prepara o teste
            var expected = "Fizz";
            var inputs = 1;
            string r;

            //2) executa o teste
            r = FizzBuzz(inputs);

            //3) verifica o teste
            Assert.AreNotEqual(expected, r);
        }

        //string Classifica(int numero)
        //{
        //    var mod3 = numero % 3 == 0;
        //    var mod5 = numero % 5 == 0;

        //    if (!mod3 && !mod5)
        //    {
        //        nDiv.Add(numero, numero.ToString());
        //    }
        //    else if (mod3 && mod5)
        //        nDiv.Add(numero, "FizzBuzz");
        //    else if (mod3)
        //        nDiv.Add(numero, "FizzBuzz");
        //    else
        //        return "Buzz";
        //}

        string FizzBuzz(int numero)
        {
            var mod3 = numero % 3 == 0;
            var mod5 = numero % 5 == 0;

            if (!mod3 && !mod5)
                return numero.ToString();
            else if (mod3 && mod5)
                return "FizzBuzz";
            else if (mod3)
                return "Fizz";
            else
                return "Buzz";
        }
    }
}
