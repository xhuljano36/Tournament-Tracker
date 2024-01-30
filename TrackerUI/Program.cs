namespace TrackerUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        { 
            // To customize application configuration such as set high DP<DirectedGraph xmlns="http://schemas.microsoft.com/vs/2009/dgml">
  <Nodes>
    <Node Id="(@1 @2)" Visibility="Hidden" />
    <Node Id="(@3 Namespace=TrackerUI Type=Program)" Category="CodeSchema_Class" CodeSchemaProperty_IsInternal="True" CodeSchemaProperty_IsStatic="True" CommonLabel="Program" Icon="Microsoft.VisualStudio.Class.Internal" IsDragSource="True" Label="Program" SourceLocation="(Assembly=file:///C:/Users/User/source/repos/tournamentTracker/TrackerUI/Program.cs StartLineNumber=2 StartCharacterOffset=26 EndLineNumber=2 EndCharacterOffset=33)" />
  </Nodes>
  <Links>
    <Link Source="(@1 @2)" Target="(@3 Namespace=TrackerUI Type=Program)" Category="Contains" />
  </Links>
  <Categories>
    <Category Id="CodeSchema_Class" Label="Class" BasedOn="CodeSchema_Type" Icon="CodeSchema_Class" />
    <Category Id="CodeSchema_Type" Label="Type" Icon="CodeSchema_Class" />
    <Category Id="Contains" Label="Contains" Description="Whether the source of the link contains the target object" IsContainment="True" />
  </Categories>
  <Properties>
    <Property Id="CodeSchemaProperty_IsInternal" Label="Is Internal" Description="Flag to indicate the method is 'Internal'" DataType="System.Boolean" />
    <Property Id="CodeSchemaProperty_IsStatic" Label="Is Static" Description="Flag to indicate the member is a static member" DataType="System.Boolean" />
    <Property Id="CommonLabel" DataType="System.String" />
    <Property Id="Icon" Label="Icon" DataType="System.String" />
    <Property Id="IsContainment" DataType="System.Boolean" />
    <Property Id="IsDragSource" Label="IsDragSource" Description="IsDragSource" DataType="System.Boolean" />
    <Property Id="Label" Label="Label" Description="Displayable label of an Annotatable object" DataType="System.String" />
    <Property Id="SourceLocation" Label="Start Line Number" DataType="Microsoft.VisualStudio.GraphModel.CodeSchema.SourceLocation" />
    <Property Id="Visibility" Label="Visibility" Description="Defines whether a node in the graph is visible or not" DataType="System.Windows.Visibility" />
  </Properties>
  <QualifiedNames>
    <Name Id="Assembly" Label="Assembly" ValueType="Uri" />
    <Name Id="File" Label="File" ValueType="Uri" />
    <Name Id="Namespace" Label="Namespace" ValueType="System.String" />
    <Name Id="Type" Label="Type" ValueType="System.Object" />
  </QualifiedNames>
  <IdentifierAliases>
    <Alias n="1" Uri="Assembly=$(VsSolutionUri)/TrackerUI/TrackerUI.csproj" />
    <Alias n="2" Uri="File=$(VsSolutionUri)/TrackerUI/Program.cs" />
    <Alias n="3" Uri="Assembly=$(c0a95fed-377a-4608-993f-816d811d1686.OutputPathUri)" />
  </IdentifierAliases>
  <Paths>
    <Path Id="c0a95fed-377a-4608-993f-816d811d1686.OutputPathUri" Value="file:///C:/Users/User/source/repos/tournamentTracker/TrackerUI/bin/Debug/net7.0-windows/TrackerUI.dll" />
    <Path Id="VsSolutionUri" Value="file:///C:/Users/User/source/repos/tournamentTracker" />
  </Paths>
</DirectedGraph>I settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new TournamentViewerForm());
        }
    }
}