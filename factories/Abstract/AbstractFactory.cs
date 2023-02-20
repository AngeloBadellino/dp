interface IButton {}
interface ILabel {}

class BlueButton : IButton {}
class GreenButton : IButton {}

class BlueLabel : ILabel {}
class GreenLabel : ILabel {}

interface IComponentAbstractFactory{
    IButton GetButton();
    ILabel GetLabel();
}

class BluComponentAbstractFactory : IComponentAbstractFactory {

    public IButton GetButton() => new BlueButton(); 
    public ILabel GetLabel() => new BlueLabel(); 
}

class GreenComponentAbstractFactory : IComponentAbstractFactory {

    public IButton GetButton() => new GreenButton(); 
    public ILabel GetLabel() => new GreenLabel(); 
}