<?xml version="1.0" encoding="utf-8"?>
<Dsl xmlns:dm0="http://schemas.microsoft.com/VisualStudio/2008/DslTools/Core" dslVersion="1.0.0.0" Id="01317cd4-1135-4994-9f06-60232d8d15e6" Description="Description for Unican.smartHome.smartHome" Name="smartHome" DisplayName="smartHome" Namespace="Unican.smartHome" ProductName="smartHome" CompanyName="Unican" PackageGuid="e7461eba-3365-432f-be54-917d1b993741" PackageNamespace="Unican.smartHome" xmlns="http://schemas.microsoft.com/VisualStudio/2005/DslTools/DslDefinitionModel">
  <Classes>
    <DomainClass Id="339f9b18-20fb-4609-90bf-26c5aa59948f" Description="The root in which all other elements are embedded. Appears as a diagram." Name="SmartHome" DisplayName="Smart Home" InheritanceModifier="Sealed" Namespace="Unican.smartHome">
      <ElementMergeDirectives>
        <ElementMergeDirective>
          <Notes>Creates an embedding link when an element is dropped onto a model. </Notes>
          <Index>
            <DomainClassMoniker Name="Floor" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>SmartHomeHasFloors.Floors</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="SmartEnergy" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>SmartHomeHasSmartEnergy.SmartEnergy</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="LightSimulation" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>SmartHomeHasLightSimulation.LightSimulation</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="BlindSimulation" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>SmartHomeHasBlindSimulation.BlindSimulation</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
      </ElementMergeDirectives>
    </DomainClass>
    <DomainClass Id="49688a4d-8cb6-4e64-a49d-b685837284e6" Description="Elements embedded in the model. Appear as boxes on the diagram." Name="Floor" DisplayName="Floor" Namespace="Unican.smartHome">
      <Properties>
        <DomainProperty Id="3b26e5a9-8fa9-4ace-8fea-1c366e66eb65" Description="Description for Unican.smartHome.Floor.Name" Name="Name" DisplayName="Name" DefaultValue="" IsElementName="true">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
      <ElementMergeDirectives>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="Room" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>FloorHasRooms.Rooms</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
      </ElementMergeDirectives>
    </DomainClass>
    <DomainClass Id="98577327-94ad-4777-ad36-2b5a522cf359" Description="Description for Unican.smartHome.Room" Name="Room" DisplayName="Room" Namespace="Unican.smartHome">
      <Properties>
        <DomainProperty Id="25f83b7d-db0b-45a1-9352-1589a56dc4fe" Description="Description for Unican.smartHome.Room.Name" Name="Name" DisplayName="Name" IsElementName="true">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
      <ElementMergeDirectives>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="Heater" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>RoomHasHeaters.Heaters</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="Window" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>RoomHasWindows.Windows</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="Light" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>RoomHasLights.Lights</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
      </ElementMergeDirectives>
    </DomainClass>
    <DomainClass Id="07b70599-d7ba-4fcb-a644-36ef95761606" Description="Description for Unican.smartHome.SmartEnergy" Name="SmartEnergy" DisplayName="Smart Energy" Namespace="Unican.smartHome" />
    <DomainClass Id="e0f48982-edaa-4d2a-b0f4-c89702b84b41" Description="Description for Unican.smartHome.LightSimulation" Name="LightSimulation" DisplayName="Light Simulation" Namespace="Unican.smartHome" />
    <DomainClass Id="9c7c873f-b1cf-44ba-b701-64370c5a62f9" Description="Description for Unican.smartHome.BlindSimulation" Name="BlindSimulation" DisplayName="Blind Simulation" Namespace="Unican.smartHome" />
    <DomainClass Id="f63cf0cc-7ae2-414b-8101-0cf54fbbbc22" Description="Description for Unican.smartHome.Heater" Name="Heater" DisplayName="Heater" Namespace="Unican.smartHome" />
    <DomainClass Id="4307924c-e5c5-4296-89c8-b884cbadb114" Description="Description for Unican.smartHome.Window" Name="Window" DisplayName="Window" Namespace="Unican.smartHome">
      <ElementMergeDirectives>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="Blind" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>WindowHasBlinds.Blinds</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
      </ElementMergeDirectives>
    </DomainClass>
    <DomainClass Id="f58edd90-074b-4dfe-a828-3aba90c59cdd" Description="Description for Unican.smartHome.Blind" Name="Blind" DisplayName="Blind" Namespace="Unican.smartHome" />
    <DomainClass Id="98f487f9-bc72-44a7-9052-ffbb946b4008" Description="Description for Unican.smartHome.Light" Name="Light" DisplayName="Light" Namespace="Unican.smartHome" />
  </Classes>
  <Relationships>
    <DomainRelationship Id="b1e3d756-b542-40bf-963b-4d57b6d24d5a" Description="Embedding relationship between the Model and Elements" Name="SmartHomeHasFloors" DisplayName="Smart Home Has Floors" Namespace="Unican.smartHome" IsEmbedding="true">
      <Source>
        <DomainRole Id="ba5d1ad2-58e1-4abf-9629-bd6235070967" Description="" Name="SmartHome" DisplayName="Smart Home" PropertyName="Floors" Multiplicity="OneMany" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Floors">
          <RolePlayer>
            <DomainClassMoniker Name="SmartHome" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="e6deb1db-710c-4835-b981-4bc2071ce1fe" Description="" Name="Element" DisplayName="Element" PropertyName="SmartHome" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Smart Home">
          <RolePlayer>
            <DomainClassMoniker Name="Floor" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="6efe760c-16d9-4e70-b0b1-8a7f0aebadf0" Description="Description for Unican.smartHome.FloorHasRooms" Name="FloorHasRooms" DisplayName="Floor Has Rooms" Namespace="Unican.smartHome" IsEmbedding="true">
      <Source>
        <DomainRole Id="bab5f396-6bb0-493e-8bfc-388bd471ae03" Description="Description for Unican.smartHome.FloorHasRooms.Floor" Name="Floor" DisplayName="Floor" PropertyName="Rooms" Multiplicity="OneMany" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Rooms">
          <RolePlayer>
            <DomainClassMoniker Name="Floor" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="95b61f6f-a316-4fb8-95fe-88c3490aa1a5" Description="Description for Unican.smartHome.FloorHasRooms.Room" Name="Room" DisplayName="Room" PropertyName="Floor" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Floor">
          <RolePlayer>
            <DomainClassMoniker Name="Room" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="f40ed51e-26b2-48c9-8cdc-2fc2712eccf6" Description="Description for Unican.smartHome.SmartHomeHasSmartEnergy" Name="SmartHomeHasSmartEnergy" DisplayName="Smart Home Has Smart Energy" Namespace="Unican.smartHome" IsEmbedding="true">
      <Source>
        <DomainRole Id="efc420ac-cc14-41bc-9763-900042447e9c" Description="Description for Unican.smartHome.SmartHomeHasSmartEnergy.SmartHome" Name="SmartHome" DisplayName="Smart Home" PropertyName="SmartEnergy" Multiplicity="ZeroOne" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Smart Energy">
          <RolePlayer>
            <DomainClassMoniker Name="SmartHome" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="6362b6d1-f262-4786-9e11-32bfeb8dce8e" Description="Description for Unican.smartHome.SmartHomeHasSmartEnergy.SmartEnergy" Name="SmartEnergy" DisplayName="Smart Energy" PropertyName="SmartHome" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Smart Home">
          <RolePlayer>
            <DomainClassMoniker Name="SmartEnergy" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="dc53a7b5-fc47-43b1-8a48-73d0bda5544a" Description="Description for Unican.smartHome.SmartHomeHasLightSimulation" Name="SmartHomeHasLightSimulation" DisplayName="Smart Home Has Light Simulation" Namespace="Unican.smartHome" IsEmbedding="true">
      <Source>
        <DomainRole Id="7c8d569a-b60c-4b37-a29f-a91080e6e4a1" Description="Description for Unican.smartHome.SmartHomeHasLightSimulation.SmartHome" Name="SmartHome" DisplayName="Smart Home" PropertyName="LightSimulation" Multiplicity="ZeroOne" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Light Simulation">
          <RolePlayer>
            <DomainClassMoniker Name="SmartHome" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="7a7f51b2-6650-4874-aee3-146c2ccbba84" Description="Description for Unican.smartHome.SmartHomeHasLightSimulation.LightSimulation" Name="LightSimulation" DisplayName="Light Simulation" PropertyName="SmartHome" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Smart Home">
          <RolePlayer>
            <DomainClassMoniker Name="LightSimulation" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="dd4a4a09-0570-4baa-a695-ba7832d2a70c" Description="Description for Unican.smartHome.SmartHomeHasBlindSimulation" Name="SmartHomeHasBlindSimulation" DisplayName="Smart Home Has Blind Simulation" Namespace="Unican.smartHome" IsEmbedding="true">
      <Source>
        <DomainRole Id="0831bef8-9e13-4737-871d-fd8784d68a65" Description="Description for Unican.smartHome.SmartHomeHasBlindSimulation.SmartHome" Name="SmartHome" DisplayName="Smart Home" PropertyName="BlindSimulation" Multiplicity="ZeroOne" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Blind Simulation">
          <RolePlayer>
            <DomainClassMoniker Name="SmartHome" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="fc56663c-1ad8-496a-b401-f5cdd5c68b81" Description="Description for Unican.smartHome.SmartHomeHasBlindSimulation.BlindSimulation" Name="BlindSimulation" DisplayName="Blind Simulation" PropertyName="SmartHome" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Smart Home">
          <RolePlayer>
            <DomainClassMoniker Name="BlindSimulation" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="1aec8149-57d6-4979-8cfe-56266ce61935" Description="Description for Unican.smartHome.RoomHasHeaters" Name="RoomHasHeaters" DisplayName="Room Has Heaters" Namespace="Unican.smartHome" IsEmbedding="true">
      <Source>
        <DomainRole Id="2234a919-64fc-459d-92b6-4bfc10014fdc" Description="Description for Unican.smartHome.RoomHasHeaters.Room" Name="Room" DisplayName="Room" PropertyName="Heaters" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Heaters">
          <RolePlayer>
            <DomainClassMoniker Name="Room" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="261b7f37-5181-4938-8962-be9307f2c363" Description="Description for Unican.smartHome.RoomHasHeaters.Heater" Name="Heater" DisplayName="Heater" PropertyName="Room" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Room">
          <RolePlayer>
            <DomainClassMoniker Name="Heater" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="7dfd65e0-3cfe-4bb6-9848-cddaa8ef8999" Description="Description for Unican.smartHome.RoomHasWindows" Name="RoomHasWindows" DisplayName="Room Has Windows" Namespace="Unican.smartHome" IsEmbedding="true">
      <Source>
        <DomainRole Id="1bb94c46-367c-4aa7-aa67-fe05a9dc1430" Description="Description for Unican.smartHome.RoomHasWindows.Room" Name="Room" DisplayName="Room" PropertyName="Windows" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Windows">
          <RolePlayer>
            <DomainClassMoniker Name="Room" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="ca1396de-fbe6-4718-adeb-bcf51593d4d0" Description="Description for Unican.smartHome.RoomHasWindows.Window" Name="Window" DisplayName="Window" PropertyName="Room" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Room">
          <RolePlayer>
            <DomainClassMoniker Name="Window" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="2070a87c-56e1-49c1-8c0b-40e54739c1f7" Description="Description for Unican.smartHome.WindowHasBlinds" Name="WindowHasBlinds" DisplayName="Window Has Blinds" Namespace="Unican.smartHome" IsEmbedding="true">
      <Source>
        <DomainRole Id="b316aa4b-c8f3-4f40-a691-a3899163cb35" Description="Description for Unican.smartHome.WindowHasBlinds.Window" Name="Window" DisplayName="Window" PropertyName="Blinds" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Blinds">
          <RolePlayer>
            <DomainClassMoniker Name="Window" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="e37eb65d-d8d5-4dd1-afca-17049d184f5b" Description="Description for Unican.smartHome.WindowHasBlinds.Blind" Name="Blind" DisplayName="Blind" PropertyName="Window" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Window">
          <RolePlayer>
            <DomainClassMoniker Name="Blind" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="6cf71e0e-a22c-4715-8606-40b6e7757ac5" Description="Description for Unican.smartHome.RoomHasLights" Name="RoomHasLights" DisplayName="Room Has Lights" Namespace="Unican.smartHome" IsEmbedding="true">
      <Source>
        <DomainRole Id="2503bbce-6089-4173-bc1d-fb24dbb12cd4" Description="Description for Unican.smartHome.RoomHasLights.Room" Name="Room" DisplayName="Room" PropertyName="Lights" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Lights">
          <RolePlayer>
            <DomainClassMoniker Name="Room" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="ef369523-bff5-4ed9-ba74-4058aa2fd1db" Description="Description for Unican.smartHome.RoomHasLights.Light" Name="Light" DisplayName="Light" PropertyName="Room" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Room">
          <RolePlayer>
            <DomainClassMoniker Name="Light" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
  </Relationships>
  <Types>
    <ExternalType Name="DateTime" Namespace="System" />
    <ExternalType Name="String" Namespace="System" />
    <ExternalType Name="Int16" Namespace="System" />
    <ExternalType Name="Int32" Namespace="System" />
    <ExternalType Name="Int64" Namespace="System" />
    <ExternalType Name="UInt16" Namespace="System" />
    <ExternalType Name="UInt32" Namespace="System" />
    <ExternalType Name="UInt64" Namespace="System" />
    <ExternalType Name="SByte" Namespace="System" />
    <ExternalType Name="Byte" Namespace="System" />
    <ExternalType Name="Double" Namespace="System" />
    <ExternalType Name="Single" Namespace="System" />
    <ExternalType Name="Guid" Namespace="System" />
    <ExternalType Name="Boolean" Namespace="System" />
    <ExternalType Name="Char" Namespace="System" />
  </Types>
  <Shapes>
    <GeometryShape Id="51655166-966f-48e5-b025-553190a046f2" Description="" Name="FloorShape" DisplayName="Floor Shape" Namespace="Unican.smartHome" FixedTooltipText="Floor Shape" FillColor="DarkKhaki" OutlineColor="113, 111, 110" InitialWidth="1" InitialHeight="1.5" Geometry="RoundedRectangle">
      <Notes>The shape has a text decorator used to display the Name property of the mapped ExampleElement.</Notes>
      <ShapeHasDecorators Position="Center" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="NameDecorator" DisplayName="Name Decorator" DefaultText="NameDecorator" />
      </ShapeHasDecorators>
    </GeometryShape>
    <GeometryShape Id="c91ec00a-f146-4a5e-951e-b2260d6a2141" Description="Description for Unican.smartHome.roomShape" Name="roomShape" DisplayName="Room Shape" Namespace="Unican.smartHome" FixedTooltipText="Room Shape" FillColor="LightSalmon" OutlineColor="113, 111, 110" InitialHeight="1" Geometry="RoundedRectangle">
      <ShapeHasDecorators Position="Center" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="NameDecorator" DisplayName="Name Decorator" DefaultText="NameDecorator" />
      </ShapeHasDecorators>
    </GeometryShape>
    <GeometryShape Id="42fd3139-7118-40ec-9442-255b99aff9a3" Description="Description for Unican.smartHome.WindowShape" Name="WindowShape" DisplayName="Window Shape" Namespace="Unican.smartHome" FixedTooltipText="Window Shape" FillColor="GradientActiveCaption" OutlineColor="113, 111, 110" InitialHeight="1" Geometry="Ellipse">
      <ShapeHasDecorators Position="Center" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="Window" DisplayName="Window" DefaultText="Window" />
      </ShapeHasDecorators>
    </GeometryShape>
    <GeometryShape Id="aab396f0-bd6e-498a-af6b-fd2470696829" Description="Description for Unican.smartHome.HeaterShape" Name="HeaterShape" DisplayName="Heater Shape" Namespace="Unican.smartHome" FixedTooltipText="Heater Shape" FillColor="IndianRed" OutlineColor="113, 111, 110" InitialHeight="1" Geometry="Ellipse">
      <ShapeHasDecorators Position="Center" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="Heater" DisplayName="Heater" DefaultText="Heater" />
      </ShapeHasDecorators>
    </GeometryShape>
    <GeometryShape Id="52a8a3b7-5d16-4962-a1d7-c63d12d3452f" Description="Description for Unican.smartHome.SmartEnergyShape" Name="SmartEnergyShape" DisplayName="Smart Energy Shape" Namespace="Unican.smartHome" FixedTooltipText="Smart Energy Shape" FillColor="InactiveCaption" OutlineColor="113, 111, 110" InitialHeight="1" Geometry="Circle">
      <ShapeHasDecorators Position="Center" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="SmartEnergy" DisplayName="Smart Energy" DefaultText="SmartEnergy" />
      </ShapeHasDecorators>
    </GeometryShape>
    <GeometryShape Id="8d26e574-b479-478d-a7b9-b005e5402367" Description="Description for Unican.smartHome.LightShape" Name="LightShape" DisplayName="Light Shape" Namespace="Unican.smartHome" FixedTooltipText="Light Shape" FillColor="Yellow" OutlineColor="113, 111, 110" InitialHeight="1" Geometry="Ellipse">
      <ShapeHasDecorators Position="Center" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="Light" DisplayName="Light" DefaultText="Light" />
      </ShapeHasDecorators>
    </GeometryShape>
    <GeometryShape Id="27e3f331-1253-4044-86f7-a838e1b6a41f" Description="Description for Unican.smartHome.BlindShape" Name="BlindShape" DisplayName="Blind Shape" Namespace="Unican.smartHome" FixedTooltipText="Blind Shape" FillColor="Peru" OutlineColor="113, 111, 110" InitialHeight="1" Geometry="Ellipse">
      <ShapeHasDecorators Position="Center" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="Blind" DisplayName="Blind" DefaultText="Blind" />
      </ShapeHasDecorators>
    </GeometryShape>
    <GeometryShape Id="7f76d146-970a-4f7c-a11f-131dbc043090" Description="Description for Unican.smartHome.LightSimulationShape" Name="LightSimulationShape" DisplayName="Light Simulation Shape" Namespace="Unican.smartHome" FixedTooltipText="Light Simulation Shape" FillColor="InactiveCaption" OutlineColor="113, 111, 110" InitialHeight="1" Geometry="Circle">
      <ShapeHasDecorators Position="Center" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="LightSimulation" DisplayName="Light Simulation" DefaultText="LightSimulation" />
      </ShapeHasDecorators>
    </GeometryShape>
    <GeometryShape Id="000b1432-8024-48be-8690-04def55656ae" Description="Description for Unican.smartHome.BlindSimulationShape" Name="BlindSimulationShape" DisplayName="Blind Simulation Shape" Namespace="Unican.smartHome" FixedTooltipText="Blind Simulation Shape" FillColor="InactiveCaption" OutlineColor="113, 111, 110" InitialHeight="1" Geometry="Circle">
      <ShapeHasDecorators Position="Center" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="BlindSimulation" DisplayName="Blind Simulation" DefaultText="BlindSimulation" />
      </ShapeHasDecorators>
    </GeometryShape>
  </Shapes>
  <Connectors>
    <Connector Id="cbc312de-6a27-4482-9074-5955db8171c4" Description="Description for Unican.smartHome.Connector" Name="Connector" DisplayName="Connector" Namespace="Unican.smartHome" FixedTooltipText="Connector" TargetEndStyle="FilledDiamond" Thickness="0.015" RoutingStyle="Straight" />
  </Connectors>
  <XmlSerializationBehavior Name="smartHomeSerializationBehavior" Namespace="Unican.smartHome">
    <ClassData>
      <XmlClassData TypeName="SmartHome" MonikerAttributeName="" SerializeId="true" MonikerElementName="smartHomeMoniker" ElementName="smartHome" MonikerTypeName="SmartHomeMoniker">
        <DomainClassMoniker Name="SmartHome" />
        <ElementData>
          <XmlRelationshipData RoleElementName="floors">
            <DomainRelationshipMoniker Name="SmartHomeHasFloors" />
          </XmlRelationshipData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="smartEnergy">
            <DomainRelationshipMoniker Name="SmartHomeHasSmartEnergy" />
          </XmlRelationshipData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="lightSimulation">
            <DomainRelationshipMoniker Name="SmartHomeHasLightSimulation" />
          </XmlRelationshipData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="blindSimulation">
            <DomainRelationshipMoniker Name="SmartHomeHasBlindSimulation" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="Floor" MonikerAttributeName="name" SerializeId="true" MonikerElementName="floorMoniker" ElementName="floor" MonikerTypeName="FloorMoniker">
        <DomainClassMoniker Name="Floor" />
        <ElementData>
          <XmlPropertyData XmlName="name" IsMonikerKey="true">
            <DomainPropertyMoniker Name="Floor/Name" />
          </XmlPropertyData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="rooms">
            <DomainRelationshipMoniker Name="FloorHasRooms" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="SmartHomeHasFloors" MonikerAttributeName="" SerializeId="true" MonikerElementName="smartHomeHasFloorsMoniker" ElementName="smartHomeHasFloors" MonikerTypeName="SmartHomeHasFloorsMoniker">
        <DomainRelationshipMoniker Name="SmartHomeHasFloors" />
      </XmlClassData>
      <XmlClassData TypeName="FloorShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="floorShapeMoniker" ElementName="floorShape" MonikerTypeName="FloorShapeMoniker">
        <GeometryShapeMoniker Name="FloorShape" />
      </XmlClassData>
      <XmlClassData TypeName="smartHomeDiagram" MonikerAttributeName="" SerializeId="true" MonikerElementName="smartHomeDiagramMoniker" ElementName="smartHomeDiagram" MonikerTypeName="SmartHomeDiagramMoniker">
        <DiagramMoniker Name="smartHomeDiagram" />
      </XmlClassData>
      <XmlClassData TypeName="FloorHasRooms" MonikerAttributeName="" SerializeId="true" MonikerElementName="floorHasRoomsMoniker" ElementName="floorHasRooms" MonikerTypeName="FloorHasRoomsMoniker">
        <DomainRelationshipMoniker Name="FloorHasRooms" />
      </XmlClassData>
      <XmlClassData TypeName="Room" MonikerAttributeName="" SerializeId="true" MonikerElementName="roomMoniker" ElementName="room" MonikerTypeName="RoomMoniker">
        <DomainClassMoniker Name="Room" />
        <ElementData>
          <XmlPropertyData XmlName="name">
            <DomainPropertyMoniker Name="Room/Name" />
          </XmlPropertyData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="heaters">
            <DomainRelationshipMoniker Name="RoomHasHeaters" />
          </XmlRelationshipData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="windows">
            <DomainRelationshipMoniker Name="RoomHasWindows" />
          </XmlRelationshipData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="lights">
            <DomainRelationshipMoniker Name="RoomHasLights" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="RoomShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="roomShapeMoniker" ElementName="roomShape" MonikerTypeName="RoomShapeMoniker">
        <GeometryShapeMoniker Name="roomShape" />
      </XmlClassData>
      <XmlClassData TypeName="Connector" MonikerAttributeName="" SerializeId="true" MonikerElementName="connectorMoniker" ElementName="connector" MonikerTypeName="ConnectorMoniker">
        <ConnectorMoniker Name="Connector" />
      </XmlClassData>
      <XmlClassData TypeName="SmartHomeHasSmartEnergy" MonikerAttributeName="" SerializeId="true" MonikerElementName="smartHomeHasSmartEnergyMoniker" ElementName="smartHomeHasSmartEnergy" MonikerTypeName="SmartHomeHasSmartEnergyMoniker">
        <DomainRelationshipMoniker Name="SmartHomeHasSmartEnergy" />
      </XmlClassData>
      <XmlClassData TypeName="SmartEnergy" MonikerAttributeName="" SerializeId="true" MonikerElementName="smartEnergyMoniker" ElementName="smartEnergy" MonikerTypeName="SmartEnergyMoniker">
        <DomainClassMoniker Name="SmartEnergy" />
      </XmlClassData>
      <XmlClassData TypeName="SmartHomeHasLightSimulation" MonikerAttributeName="" SerializeId="true" MonikerElementName="smartHomeHasLightSimulationMoniker" ElementName="smartHomeHasLightSimulation" MonikerTypeName="SmartHomeHasLightSimulationMoniker">
        <DomainRelationshipMoniker Name="SmartHomeHasLightSimulation" />
      </XmlClassData>
      <XmlClassData TypeName="LightSimulation" MonikerAttributeName="" SerializeId="true" MonikerElementName="lightSimulationMoniker" ElementName="lightSimulation" MonikerTypeName="LightSimulationMoniker">
        <DomainClassMoniker Name="LightSimulation" />
      </XmlClassData>
      <XmlClassData TypeName="SmartHomeHasBlindSimulation" MonikerAttributeName="" SerializeId="true" MonikerElementName="smartHomeHasBlindSimulationMoniker" ElementName="smartHomeHasBlindSimulation" MonikerTypeName="SmartHomeHasBlindSimulationMoniker">
        <DomainRelationshipMoniker Name="SmartHomeHasBlindSimulation" />
      </XmlClassData>
      <XmlClassData TypeName="BlindSimulation" MonikerAttributeName="" SerializeId="true" MonikerElementName="blindSimulationMoniker" ElementName="blindSimulation" MonikerTypeName="BlindSimulationMoniker">
        <DomainClassMoniker Name="BlindSimulation" />
      </XmlClassData>
      <XmlClassData TypeName="RoomHasHeaters" MonikerAttributeName="" SerializeId="true" MonikerElementName="roomHasHeatersMoniker" ElementName="roomHasHeaters" MonikerTypeName="RoomHasHeatersMoniker">
        <DomainRelationshipMoniker Name="RoomHasHeaters" />
      </XmlClassData>
      <XmlClassData TypeName="Heater" MonikerAttributeName="" SerializeId="true" MonikerElementName="heaterMoniker" ElementName="heater" MonikerTypeName="HeaterMoniker">
        <DomainClassMoniker Name="Heater" />
      </XmlClassData>
      <XmlClassData TypeName="RoomHasWindows" MonikerAttributeName="" SerializeId="true" MonikerElementName="roomHasWindowsMoniker" ElementName="roomHasWindows" MonikerTypeName="RoomHasWindowsMoniker">
        <DomainRelationshipMoniker Name="RoomHasWindows" />
      </XmlClassData>
      <XmlClassData TypeName="Window" MonikerAttributeName="" SerializeId="true" MonikerElementName="windowMoniker" ElementName="window" MonikerTypeName="WindowMoniker">
        <DomainClassMoniker Name="Window" />
        <ElementData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="blinds">
            <DomainRelationshipMoniker Name="WindowHasBlinds" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="WindowHasBlinds" MonikerAttributeName="" SerializeId="true" MonikerElementName="windowHasBlindsMoniker" ElementName="windowHasBlinds" MonikerTypeName="WindowHasBlindsMoniker">
        <DomainRelationshipMoniker Name="WindowHasBlinds" />
      </XmlClassData>
      <XmlClassData TypeName="Blind" MonikerAttributeName="" SerializeId="true" MonikerElementName="blindMoniker" ElementName="blind" MonikerTypeName="BlindMoniker">
        <DomainClassMoniker Name="Blind" />
      </XmlClassData>
      <XmlClassData TypeName="RoomHasLights" MonikerAttributeName="" SerializeId="true" MonikerElementName="roomHasLightsMoniker" ElementName="roomHasLights" MonikerTypeName="RoomHasLightsMoniker">
        <DomainRelationshipMoniker Name="RoomHasLights" />
      </XmlClassData>
      <XmlClassData TypeName="Light" MonikerAttributeName="" SerializeId="true" MonikerElementName="lightMoniker" ElementName="light" MonikerTypeName="LightMoniker">
        <DomainClassMoniker Name="Light" />
      </XmlClassData>
      <XmlClassData TypeName="WindowShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="windowShapeMoniker" ElementName="windowShape" MonikerTypeName="WindowShapeMoniker">
        <GeometryShapeMoniker Name="WindowShape" />
      </XmlClassData>
      <XmlClassData TypeName="HeaterShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="heaterShapeMoniker" ElementName="heaterShape" MonikerTypeName="HeaterShapeMoniker">
        <GeometryShapeMoniker Name="HeaterShape" />
      </XmlClassData>
      <XmlClassData TypeName="SmartEnergyShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="smartEnergyShapeMoniker" ElementName="smartEnergyShape" MonikerTypeName="SmartEnergyShapeMoniker">
        <GeometryShapeMoniker Name="SmartEnergyShape" />
      </XmlClassData>
      <XmlClassData TypeName="LightShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="lightShapeMoniker" ElementName="lightShape" MonikerTypeName="LightShapeMoniker">
        <GeometryShapeMoniker Name="LightShape" />
      </XmlClassData>
      <XmlClassData TypeName="BlindShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="blindShapeMoniker" ElementName="blindShape" MonikerTypeName="BlindShapeMoniker">
        <GeometryShapeMoniker Name="BlindShape" />
      </XmlClassData>
      <XmlClassData TypeName="LightSimulationShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="lightSimulationShapeMoniker" ElementName="lightSimulationShape" MonikerTypeName="LightSimulationShapeMoniker">
        <GeometryShapeMoniker Name="LightSimulationShape" />
      </XmlClassData>
      <XmlClassData TypeName="BlindSimulationShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="blindSimulationShapeMoniker" ElementName="blindSimulationShape" MonikerTypeName="BlindSimulationShapeMoniker">
        <GeometryShapeMoniker Name="BlindSimulationShape" />
      </XmlClassData>
    </ClassData>
  </XmlSerializationBehavior>
  <ExplorerBehavior Name="smartHomeExplorer" />
  <Diagram Id="a231ca39-f0b9-4b83-9a6a-adf72933a074" Description="Description for Unican.smartHome.smartHomeDiagram" Name="smartHomeDiagram" DisplayName="Smart Home Diagram" Namespace="Unican.smartHome">
    <Class>
      <DomainClassMoniker Name="SmartHome" />
    </Class>
    <ShapeMaps>
      <ShapeMap>
        <DomainClassMoniker Name="Floor" />
        <ParentElementPath>
          <DomainPath>SmartHomeHasFloors.SmartHome/!SmartHome</DomainPath>
        </ParentElementPath>
        <DecoratorMap>
          <TextDecoratorMoniker Name="FloorShape/NameDecorator" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Floor/Name" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <GeometryShapeMoniker Name="FloorShape" />
      </ShapeMap>
      <ShapeMap>
        <DomainClassMoniker Name="Room" />
        <ParentElementPath>
          <DomainPath>FloorHasRooms.Floor/!Floor/SmartHomeHasFloors.SmartHome/!SmartHome</DomainPath>
        </ParentElementPath>
        <DecoratorMap>
          <TextDecoratorMoniker Name="roomShape/NameDecorator" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Room/Name" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <GeometryShapeMoniker Name="roomShape" />
      </ShapeMap>
      <ShapeMap>
        <DomainClassMoniker Name="Window" />
        <ParentElementPath>
          <DomainPath>RoomHasWindows.Room/!Room/FloorHasRooms.Floor/!Floor/SmartHomeHasFloors.SmartHome/!SmartHome</DomainPath>
        </ParentElementPath>
        <GeometryShapeMoniker Name="WindowShape" />
      </ShapeMap>
      <ShapeMap>
        <DomainClassMoniker Name="Heater" />
        <ParentElementPath>
          <DomainPath>RoomHasHeaters.Room/!Room/FloorHasRooms.Floor/!Floor/SmartHomeHasFloors.SmartHome/!SmartHome</DomainPath>
        </ParentElementPath>
        <GeometryShapeMoniker Name="HeaterShape" />
      </ShapeMap>
      <ShapeMap>
        <DomainClassMoniker Name="SmartEnergy" />
        <ParentElementPath>
          <DomainPath>SmartHomeHasSmartEnergy.SmartHome/!SmartHome</DomainPath>
        </ParentElementPath>
        <GeometryShapeMoniker Name="SmartEnergyShape" />
      </ShapeMap>
      <ShapeMap>
        <DomainClassMoniker Name="Light" />
        <ParentElementPath>
          <DomainPath>RoomHasLights.Room/!Room/FloorHasRooms.Floor/!Floor/SmartHomeHasFloors.SmartHome/!SmartHome</DomainPath>
        </ParentElementPath>
        <GeometryShapeMoniker Name="LightShape" />
      </ShapeMap>
      <ShapeMap>
        <DomainClassMoniker Name="Blind" />
        <ParentElementPath>
          <DomainPath>WindowHasBlinds.Window/!Window/RoomHasWindows.Room/!Room/FloorHasRooms.Floor/!Floor/SmartHomeHasFloors.SmartHome/!SmartHome</DomainPath>
        </ParentElementPath>
        <GeometryShapeMoniker Name="BlindShape" />
      </ShapeMap>
      <ShapeMap>
        <DomainClassMoniker Name="LightSimulation" />
        <ParentElementPath>
          <DomainPath>SmartHomeHasLightSimulation.SmartHome/!SmartHome</DomainPath>
        </ParentElementPath>
        <GeometryShapeMoniker Name="LightSimulationShape" />
      </ShapeMap>
      <ShapeMap>
        <DomainClassMoniker Name="BlindSimulation" />
        <ParentElementPath>
          <DomainPath>SmartHomeHasBlindSimulation.SmartHome/!SmartHome</DomainPath>
        </ParentElementPath>
        <GeometryShapeMoniker Name="BlindSimulationShape" />
      </ShapeMap>
    </ShapeMaps>
    <ConnectorMaps>
      <ConnectorMap>
        <ConnectorMoniker Name="Connector" />
        <DomainRelationshipMoniker Name="FloorHasRooms" />
      </ConnectorMap>
      <ConnectorMap>
        <ConnectorMoniker Name="Connector" />
        <DomainRelationshipMoniker Name="RoomHasHeaters" />
      </ConnectorMap>
      <ConnectorMap>
        <ConnectorMoniker Name="Connector" />
        <DomainRelationshipMoniker Name="RoomHasWindows" />
      </ConnectorMap>
      <ConnectorMap>
        <ConnectorMoniker Name="Connector" />
        <DomainRelationshipMoniker Name="WindowHasBlinds" />
      </ConnectorMap>
      <ConnectorMap>
        <ConnectorMoniker Name="Connector" />
        <DomainRelationshipMoniker Name="RoomHasLights" />
      </ConnectorMap>
    </ConnectorMaps>
  </Diagram>
  <Designer CopyPasteGeneration="CopyPasteOnly" FileExtension="sh" EditorGuid="52610b45-775b-4251-bb65-fa99963408c9">
    <RootClass>
      <DomainClassMoniker Name="SmartHome" />
    </RootClass>
    <XmlSerializationDefinition CustomPostLoad="false">
      <XmlSerializationBehaviorMoniker Name="smartHomeSerializationBehavior" />
    </XmlSerializationDefinition>
    <ToolboxTab TabText="smartHome">
      <ElementTool Name="Floor" ToolboxIcon="resources\exampleshapetoolbitmap.bmp" Caption="Floor" Tooltip="Create a floor" HelpKeyword="CreateExampleClassF1Keyword">
        <DomainClassMoniker Name="Floor" />
      </ElementTool>
      <ElementTool Name="Room" ToolboxIcon="Resources\ExampleShapeToolBitmap.bmp" Caption="Room" Tooltip="Room" HelpKeyword="Room">
        <DomainClassMoniker Name="Room" />
      </ElementTool>
      <ElementTool Name="Heater" ToolboxIcon="Resources\ExampleShapeToolBitmap.bmp" Caption="Heater" Tooltip="Heater" HelpKeyword="Heater">
        <DomainClassMoniker Name="Heater" />
      </ElementTool>
      <ElementTool Name="Window" ToolboxIcon="Resources\ExampleShapeToolBitmap.bmp" Caption="Window" Tooltip="Window" HelpKeyword="Window">
        <DomainClassMoniker Name="Window" />
      </ElementTool>
      <ElementTool Name="SmartEnergy" ToolboxIcon="Resources\ExampleShapeToolBitmap.bmp" Caption="SmartEnergy" Tooltip="Smart Energy" HelpKeyword="SmartEnergy">
        <DomainClassMoniker Name="SmartEnergy" />
      </ElementTool>
      <ElementTool Name="Blind" ToolboxIcon="Resources\ExampleShapeToolBitmap.bmp" Caption="Blind" Tooltip="Blind" HelpKeyword="Blind">
        <DomainClassMoniker Name="Blind" />
      </ElementTool>
      <ElementTool Name="Light" ToolboxIcon="Resources\ExampleShapeToolBitmap.bmp" Caption="Light" Tooltip="Light" HelpKeyword="Light">
        <DomainClassMoniker Name="Light" />
      </ElementTool>
      <ElementTool Name="LightSimulation" ToolboxIcon="Resources\ExampleShapeToolBitmap.bmp" Caption="LightSimulation" Tooltip="Light Simulation" HelpKeyword="LightSimulation">
        <DomainClassMoniker Name="LightSimulation" />
      </ElementTool>
      <ElementTool Name="BlindSimulation" ToolboxIcon="Resources\ExampleShapeToolBitmap.bmp" Caption="BlindSimulation" Tooltip="Blind Simulation" HelpKeyword="BlindSimulation">
        <DomainClassMoniker Name="BlindSimulation" />
      </ElementTool>
    </ToolboxTab>
    <Validation UsesMenu="true" UsesOpen="true" UsesSave="true" UsesCustom="true" UsesLoad="true" />
    <DiagramMoniker Name="smartHomeDiagram" />
  </Designer>
  <Explorer ExplorerGuid="46470cba-a2b8-49df-9ba1-8058e55a71b7" Title="smartHome Explorer">
    <ExplorerBehaviorMoniker Name="smartHome/smartHomeExplorer" />
  </Explorer>
</Dsl>