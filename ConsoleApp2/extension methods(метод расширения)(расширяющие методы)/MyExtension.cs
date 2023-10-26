namespace extension_methods_метод_расширения__расширяющие_методы_
{
    static class MyExtension
    {
        public static string GetFullName(this Student student)
        {
            return student.LastName + " " + student.FirstName;
        }
    }
}
