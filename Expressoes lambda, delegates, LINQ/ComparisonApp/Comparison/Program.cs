// Demonstração prática da função SORT que recebe como argumento outra função
//delegate - referência a função

using Comparison.Entities;

List<Product> list = new List<Product>();

list.Add(new Product("TV", 900.00));
list.Add(new Product("Notebook", 1200.00));
list.Add(new Product("Tablet", 450.00));

Comparison<Product> comp = CompareProducts;

Comparison<Product> comp2 = (p1, p2) => p1.Produto.ToUpper().CompareTo(p2.Produto.ToUpper());

// Quatro formas de realizar:

// Referência simples de méetodo como parâmetro
list.Sort(CompareProducts);

// Referencia de método atribuído a uma variável tipo delegate
list.Sort(comp);

// Expressão lambda atribuída a uma variável tipo delegate
list.Sort(comp2);

// Expressão lambda inline
list.Sort((p1, p2) => p1.Produto.ToUpper().CompareTo(p2.Produto.ToUpper()));

foreach (Product product in list)
{
    Console.WriteLine(product);
}



static int CompareProducts(Product product1, Product product2)
{
    return product1.Produto.ToUpper().CompareTo(product2.Produto.ToUpper());
}