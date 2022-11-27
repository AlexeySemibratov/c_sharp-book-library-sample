using BookLibrary.Data.Entity;

namespace BookLibrary.Data
{
    public static class Authors
    {
        public static Author AlexanderPushkin = new Author("Александр", "Сергеевич", "Пушкин");
        public static Author LevTolstoy = new Author("Лев", "Николаевич", "Толстой");
        public static Author RayBradbury = new Author("Рей", "Дуглас", "Брэдбери");
        public static Author PauloCoelho = new Author("Пауло", "", "Коэльо");
        public static Author MaksimGorky = new Author("Максим", "", "Горький");
    }
}
