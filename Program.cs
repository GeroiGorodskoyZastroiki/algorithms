Console.WriteLine(new object[] { 1, new object[] { 15.5f, new object[] { "1", "2", "3" }}}.NestedCount());
Console.WriteLine(IsTriangularNumber.IsNumberTriangular(5));
Console.WriteLine(IsTriangularNumber.IsNumberTriangular(500000000500000000));
Console.WriteLine(Decryptor.DeCrypt("crazy", "csaerntiofarmit  on  ")); // "sacretinformati o  n" - это правильный ответ, ответ из задания неверен
Console.WriteLine(Decryptor.DeCrypt("abc", "abcd")); // "abcd"
Console.WriteLine(Decryptor.DeCrypt("ba", "2143658709")); // "1234567890"
Console.WriteLine(Decryptor.DeCrypt("key", "eky")); // "key"
