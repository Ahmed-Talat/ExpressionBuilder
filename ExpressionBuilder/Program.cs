var query = (new List<Book>()).AsQueryable();

var x = "Header.Page" ; 

var predicate = ExpressionBuilder.BuildPredicate<Book>(12, OperatorComparer.LessThan, x.Split('.'));

query = query.Where(predicate);

Console.WriteLine("Expression Tree: {0}", predicate);