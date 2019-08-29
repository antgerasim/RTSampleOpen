<?xml version="1.0" encoding="utf-8"?>
<configurationSectionModel xmlns:dm0="http://schemas.microsoft.com/VisualStudio/2008/DslTools/Core" dslVersion="1.0.0.0" Id="3d359a0d-a0b0-4c94-8063-29d3fc0556c2" namespace="Xdsoft.RTK.ExtCrmWeb" xmlSchemaNamespace="urn:Xdsoft.RTK.ExtCrmWeb" xmlns="http://schemas.microsoft.com/dsltools/ConfigurationSectionDesigner">
  <typeDefinitions>
    <externalType name="String" namespace="System" />
    <externalType name="Boolean" namespace="System" />
    <externalType name="Int32" namespace="System" />
    <externalType name="Int64" namespace="System" />
    <externalType name="Single" namespace="System" />
    <externalType name="Double" namespace="System" />
    <externalType name="DateTime" namespace="System" />
    <externalType name="TimeSpan" namespace="System" />
  </typeDefinitions>
  <configurationElements>
    <configurationSection name="TutorialSection" codeGenOptions="Singleton, XmlnsProperty" xmlSectionName="tutorialSection">
      <elementProperties>
        <elementProperty name="Foobars" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="foobars" isReadOnly="false">
          <type>
            <configurationElementMoniker name="/3d359a0d-a0b0-4c94-8063-29d3fc0556c2/Foobar" />
          </type>
        </elementProperty>
        <elementProperty name="Tutorial" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="tutorial" isReadOnly="false">
          <type>
            <configurationElementMoniker name="/3d359a0d-a0b0-4c94-8063-29d3fc0556c2/Tutorial" />
          </type>
        </elementProperty>
      </elementProperties>
    </configurationSection>
    <configurationSectionGroup name="Foobars" />
    <configurationElement name="Tutorial" />
    <configurationElement name="Foobar">
      <attributeProperties>
        <attributeProperty name="Key" isRequired="true" isKey="true" isDefaultCollection="false" xmlName="key" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/3d359a0d-a0b0-4c94-8063-29d3fc0556c2/String" />
          </type>
        </attributeProperty>
      </attributeProperties>
    </configurationElement>
  </configurationElements>
  <propertyValidators>
    <validators />
  </propertyValidators>
</configurationSectionModel>