namespace rekursiya_metodi_i_stek__perepolnenie_steka
{
    internal class Program
    {
        //    static void Foo(int i)
        //    {
        //        Console.WriteLine(i);

        //        if(i >=3)
        //        {
        //            return;
        //        }
        //        i++;
        //        Foo(i);
        //    }
        //    static void Main(string[] args)
        //    {
        //        Foo(0);
        //    }
        //}
        class Item
        {
            public int Value { get; set; }
            public Item Child { get; set; }
        }

        static Item InitItem()
        {
            return new Item()
            {
                Value = 5,
                Child = new Item()
                {
                    Value = 10,
                    Child = new Item()
                    {
                        Value = 100
                    }
                }
            };
        }
        static void Print(Item item)
        {
            if (item != null)
            {
                Console.WriteLine(item.Value);
                Print(item.Child);
            }
        }
        static void Main(string[] args)
        {
            //// здесь в этом месте мы использовали метод рекурсивно.
            Item item = InitItem();
            //Print(item);
            //здесь никакая рекурсия не используется а используется только цикл for
            for (Item i = item; i != null; i = i.Child)
            {
                Console.WriteLine(i.Value);
            }
        }
    }
}
