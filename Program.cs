using System.Linq;
using LINQ.Entities;
namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
                LINQ - Language Integraded Query
                É um conjunto de tecnologias baseadas na integração de funcionalidades de consulta diretamente
                na linguagem C#.
                    - Operações chamadas diretamente a partir das coleções
                    - Consultas são objetos de primeira classe
                    - Suporte do compilador e IntelliSense da IDE

                Namespace: System.Linq

                Possui diversas operações de consulta, cujos parâmetros tipicamente são expressões lambda ou expressões
                de sintaxe similar à SQL
             

            Especificar o data source
             int[] numbers = new int[] {2, 3, 4, 5};

            Definir a consulta
            Multiplicar todos os numeros pares por 10, e criar uma nova coleção
             var result = numbers
             .Where(x => x % 2 == 0) ----- Para cada número cuja divisão por 2 tenha resto 0
             .Select(x => x * 10); ----- Multiplique por 10

            Executar a query
             foreach (int x in result)
             {
                 Console.WriteLine(x);
             } */

            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product> products = new List<Product>
            {
                new Product() {Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() {Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() {Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() {Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() {Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() {Id = 1, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() {Id = 1, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() {Id = 1, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() {Id = 1, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() {Id = 1, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() {Id = 1, Name = "Level", Price = 70.0, Category = c1 }
            };

            // Imprimir produtos cuja categoria seja 1, e preço menor que 900
            //var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            // Sintaxe alternativa - SQL
            var r1 =
                    from p in products
                    where p.Category.Tier == 1 && p.Price < 900.0
                    select p;
            Print("Tier 1 Products and Price < 900: ", r1);

            //var r2 = products.Where(p => p.Category.Name == "Tools")// Recebe produtos cuja categoria seja Tools
            //.Select(p => p.Name);// Filtra os produtos da função lambda anterior, e recebe apenas os nomes
            var r2 = 
                    from p in products
                    where p.Category.Name == "Tools"
                    select p.Name;
            Print("Names of products from Tools Category: ", r2);

            // Produtos cujo nome começa com a letra C
            // var r3 = products.Where(p => p.Name[0] == 'C')
            // Filtrar apenas nome, preço e categoria
            //.Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });// Nome da categoria recebe um Alias CategoryName
            var r3 = 
                    from p in products
                    where p.Name[0] == 'C'
                    select new {
                        p.Name,
                        p.Price,
                        CategoryName = p.Category.Name
                    };
            Print("Names started with C and Anonymous Object: ", r3);

            // Produtos de Categoria 1
            //var r4 = products.Where(p => p.Category.Tier == 1)
            //.OrderBy(p => p.Price)// Ordena por Preço
            //.ThenBy(p => p.Name);// Ordena a coleção da função anterior por Nome
            var r4 = 
                    from p in products
                    where p.Category.Tier == 1
                    orderby p.Name
                    orderby p.Price
                    select p;
            Print("Products from Category Tier 1: ", r4);

            // Skip e Take = Pular os 2 primeiros resultados, e retornar 4 objetos da coleção
            //var r5 = r4.Skip(2).Take(4);
            var r5 = 
                    (from p in r4
                    select p).Skip(2).Take(4);
            Print("Products from Category Tier 1 - Skip 2, Take 4: ", r5);

            var r6 = products.First();
            Console.WriteLine("First, test 1: " + r6);
            var r7 = products.Where(p => p.Price > 3000.00).FirstOrDefault(); // Retornará nulo
            Console.WriteLine("First, test 2: " + r7);

            var r8 = products.Where(p => p.Id == 3)
            .SingleOrDefault();// Retorna 1 elemento caso ele exista
            Console.WriteLine("SingleOrDefault test 1: " + r8);

            var r9 = products.Where(p => p.Id == 30)
            .SingleOrDefault();// Retorna 1 elemento caso ele exista
            Console.WriteLine("SingleOrDefault test 2: " + r9);

            // Retorna o valor máximo com base no preço
            var r10 = products.Max(p => p.Price);
            Console.WriteLine("Max Price: R$" + r10.ToString("F2"));

            // Retorna o valor mínimo com base no preço
            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Min Price: R$" + r11.ToString("F2"));

            // Soma dos preços dos produtos de categoria 1
            var r12 = products.Where(p => p.Category.Id == 1)
            .Sum(p => p.Price);
            Console.WriteLine("Category 1 Sum Prices: R$" + r12.ToString("F2"));

            // Média dos preços dos produtos de categoria 1
            var r13 = products.Where(p => p.Category.Id == 1)
            .Average(p => p.Price);
            Console.WriteLine("Category 1 Average Prices: R$" + r13.ToString("F2"));

            // Caso a coleção esteja vazia, retorna 0
            var r14 = products.Where(p => p.Category.Id == 5)
            .Select(p => p.Price)
            .DefaultIfEmpty(0.0)
            .Average();
            Console.WriteLine("Category 5 Average Prices: R$" + r14.ToString("F2"));

            // Soma dos preços de produtos categoria 1 usando aggregate
            var r15 = products.Where(p => p.Category.Id == 1)
            .Select(p => p.Price)
            .Aggregate((x, y) => x + y);
            Console.WriteLine("Category 1 Aggregate Sum: R$" + r15.ToString("F2"));

            // Agrupamento
            //var r16 = products.GroupBy( p => p.Category);
            var r16 =
                    from p in products
                    group p by p.Category;
            foreach (IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine("Category " + group.Key.Name + ": ");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }

        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
    }
}