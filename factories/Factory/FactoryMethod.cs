interface IProduct { }

class SmartPhone : IProduct { }

class Tablet : IProduct { }


abstract class ProductCreator{

    abstract IProduct FactoryMethod();
}

class  SmartphoneCreator : ProductCreator
{
    public override IProduct FactoryMethod(){
        return new SmartPhone();
    }
}

class TabletCreator : ProductCreator
{
    public override IProduct FactoryMethod(){
        return new Tablet();
    }
}

class Client{

    public void Main(){
        var smartPhone = SmartphoneCreator().FactoryMethod();
        var tablet = TabletCreator().FactoryMethod();
    }
}

