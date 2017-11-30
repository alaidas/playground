using System;
using System.Linq;
using Cassandra;

namespace CassandraTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Cluster cluster = Cluster.Builder().AddContactPoint("Y41507").Build();
            ISession session = cluster.Connect("demo");

            string guid = Guid.NewGuid().ToString();
            session.Execute($"insert into users (id, lastname, age, city, email, firstname) values ('{guid}', 'Jones', 35, 'Austin', 'bob@example.com', 'Bob')");

            Row result = session.Execute($"select * from users where id='{guid}'").First();
            Console.WriteLine("{0} {1}", result["firstname"], result["age"]);

            session.Execute($"update users set age = 36 where id = '{guid}'");
            result = session.Execute($"select * from users where id='{guid}'").First();
            Console.WriteLine("{0} {1}", result["firstname"], result["age"]);

            session.Execute($"delete from users where id = '{guid}'");

            RowSet rows = session.Execute("select * from users");
            foreach (Row row in rows)
                Console.WriteLine("{0} {1}", row["firstname"], row["age"]);

            Console.ReadLine();
        }
    }
}
