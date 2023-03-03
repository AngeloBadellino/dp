namespace patterns.FactoryMethod {
  interface IProduct {}

  class SmartPhone implements IProduct {}
  class Tablet implements IProduct {}

  abstract class ProductCreator {
    abstract factoryMethod(): IProduct;
  }

  class SmartPhoneCreator extends ProductCreator {
    public factoryMethod(): IProduct {
      return new SmartPhone();
    }
  }

  class TabletCreator extends ProductCreator {
    public factoryMethod(): IProduct {
      return new Tablet();
    }
  }
}
