//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    static readonly FlagAddedAndRemovedEventComponent flagAddedAndRemovedEventComponent = new FlagAddedAndRemovedEventComponent();

    public bool isFlagAddedAndRemovedEvent {
        get { return HasComponent(TestComponentsLookup.FlagAddedAndRemovedEvent); }
        set {
            if (value != isFlagAddedAndRemovedEvent) {
                var index = TestComponentsLookup.FlagAddedAndRemovedEvent;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : flagAddedAndRemovedEventComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class TestMatcher {

    static Entitas.IMatcher<TestEntity> _matcherFlagAddedAndRemovedEvent;

    public static Entitas.IMatcher<TestEntity> FlagAddedAndRemovedEvent {
        get {
            if (_matcherFlagAddedAndRemovedEvent == null) {
                var matcher = (Entitas.Matcher<TestEntity>)Entitas.Matcher<TestEntity>.AllOf(TestComponentsLookup.FlagAddedAndRemovedEvent);
                matcher.componentNames = TestComponentsLookup.componentNames;
                _matcherFlagAddedAndRemovedEvent = matcher;
            }

            return _matcherFlagAddedAndRemovedEvent;
        }
    }
}