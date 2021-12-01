abstract class MyAbstractClass {
    public abstract string Bar { get; set;}

    public readonly int foo = 42;
    public abstract void ponderMyOrb();
    public void ponderVeryHard() {

    }
    public static int ab() => 42;
   private int fooo = 42;
}

interface MyInterface {
   public int foo {get { return 42; } } 
}

interface MyGInt<T> {}

record Foo: MyInterface;
record Baz<T>: MyInterface;
record Gaz: MyGInt<int>;