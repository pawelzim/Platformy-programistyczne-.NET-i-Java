using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Lab_1_2;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReturnEmptyList_Test()
        {
            List<Item> items = new List<Item>();
            for (int i = 10; i <= 100; i=i+10)
            {
                items.Add(new Item(((i / 10) - 1), i, i));
            }
            items = Solve.solve(items, 5);
            Assert.AreEqual(0, items.Count());
        }
        [TestMethod]
        public void ReturnList_Test()
        {
            List<Item> items = new List<Item>();
            for (int i = 10; i <= 100; i = i + 10)
            {
                items.Add(new Item(((i / 10) - 1), i, i));
            }
            items = Solve.solve(items, 100);
            Assert.IsTrue(items.Count() > 0);
        }
        [TestMethod]
        public void RandomOrderOnSecondList_Test()
        {
            List<Item> items1 = new List<Item>();
            List<Item> items2 = new List<Item>();
            Random random = new Random(2);
            int rand1, rand2;


            for (int i = 0; i < 10; i++)
            {
                rand1 = random.Next(1, 11);
                rand2 = random.Next(1, 11);
                items1.Add(new Item(i, rand1, rand2));
                items2.Add(new Item(i, rand1, rand2));
            }

            int ctr = 3;
            for (int i = 0; i < items2.Count; i += 2)
            {
                if (ctr == 9)
                {
                    ctr = 1;
                }
                var value = items2[i];
                items2[i] = items2[ctr];
                items2[ctr] = value;
                ctr += 3;
            }

            items1 = Solve.solve(items1, 25);
            items2 = Solve.solve(items2, 25);
            for (int i = 0; i < items1.Count; i++)
            {
                Assert.AreEqual((items1[i].weight, items1[i].value), (items2[i].weight, items2[i].value));
            }
        }
        [TestMethod]
        public void SpecificScenario_Test()
        {
            List<Item> testItems = new List<Item>();
            List<Item> correctItems = new List<Item>();

            testItems.Add(new Item(0, 5, 2));
            testItems.Add(new Item(1, 1, 2));
            testItems.Add(new Item(2, 9, 8));
            testItems.Add(new Item(3, 7, 4));
            testItems.Add(new Item(4, 15, 5));

            correctItems.Add(new Item(4, 15, 5));
            correctItems.Add(new Item(0, 5, 2));
            correctItems.Add(new Item(1, 1, 2));

            testItems = Solve.solve(testItems, 10);

            for (int i=0; i < testItems.Count; i++)
            {
                Assert.AreEqual((testItems[i].number, testItems[i].weight, testItems[i].value), (correctItems[i].number, correctItems[i].weight, correctItems[i].value));
            }
        }
        [TestMethod]
        public void zeroCapacity_Test()
        {
            List<Item> items = new List<Item>();
            items.Add(new Item(0, 5, 2));
            items.Add(new Item(1, 1, 2));
            items.Add(new Item(2, 9, 8));

            items = Solve.solve(items, 0);

            Assert.IsTrue(items.Count == 0);
        }
        [TestMethod]
        public void zeroItems_Test()
        {
            List<Item> items = new List<Item> ();
            items = Solve.solve(items, 15);

            Assert.IsTrue(items.Count == 0);
        }
        [TestMethod]
        public void negativeCapacity_Test()
        {
            List<Item> items = new List<Item>();
            items.Add(new Item(0, 5, 2));
            items.Add(new Item(1, 1, 2));
            items.Add(new Item(2, 9, 8));

            items = Solve.solve(items, -20);

            Assert.IsTrue(items.Count == 0);
        }
        [TestMethod]
        public void negativeItemProperties_Test()
        {
            List<Item> items = new List<Item>();
            items.Add(new Item(-1, 2, 3));
            items.Add(new Item(0, -5, 1));
            items.Add(new Item(1, 5, -5));
            items.Add(new Item(-2, -9, -9));
            
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual((items[i].value, items[i].weight), (0, 0));
            }
        }
    }
}