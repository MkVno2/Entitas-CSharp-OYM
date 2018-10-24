//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    public UniqueEventListenerComponent uniqueEventListener { get { return (UniqueEventListenerComponent)GetComponent(TestComponentsLookup.UniqueEventListener); } }
    public bool hasUniqueEventListener { get { return HasComponent(TestComponentsLookup.UniqueEventListener); } }

    public void AddUniqueEventListener(System.Collections.Generic.List<IUniqueEventListener> newValue) {
        var index = TestComponentsLookup.UniqueEventListener;
        var component = (UniqueEventListenerComponent)CreateComponent(index, typeof(UniqueEventListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceUniqueEventListener(System.Collections.Generic.List<IUniqueEventListener> newValue) {
        var index = TestComponentsLookup.UniqueEventListener;
        var component = (UniqueEventListenerComponent)CreateComponent(index, typeof(UniqueEventListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveUniqueEventListener() {
        RemoveComponent(TestComponentsLookup.UniqueEventListener);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class TestMatcher {

    static Entitas.IMatcher<TestEntity> _matcherUniqueEventListener;

    public static Entitas.IMatcher<TestEntity> UniqueEventListener {
        get {
            if (_matcherUniqueEventListener == null) {
                var matcher = (Entitas.Matcher<TestEntity>)Entitas.Matcher<TestEntity>.AllOf(TestComponentsLookup.UniqueEventListener);
                matcher.componentNames = TestComponentsLookup.componentNames;
                _matcherUniqueEventListener = matcher;
            }

            return _matcherUniqueEventListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    public void AddUniqueEventListener(IUniqueEventListener value) {
        var listeners = hasUniqueEventListener
            ? uniqueEventListener.value
            : new System.Collections.Generic.List<IUniqueEventListener>();
        listeners.Add(value);
        ReplaceUniqueEventListener(listeners);
    }

    public void RemoveUniqueEventListener(IUniqueEventListener value, bool removeComponentWhenEmpty = true) {
        var listeners = uniqueEventListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveUniqueEventListener();
        } else {
            ReplaceUniqueEventListener(listeners);
        }
    }
}