# ApontarReferenciaParaProjetoLocal
Me deparei com o problema de precisar fazer uma referência para um projeto local pelo VS Code

Achei a seguinte referência:

simpler, just add the following:

1) modify the myproject.csproj file

    <ItemGroup>
     <Reference Include="DllComunVb2008">
       <HintPath>..\Dlls\DllComunVb2008.dll</HintPath>
     </Reference>
    </ItemGroup>
2) Add the using of the library you are going to use. Example: using Dllcomun;

No seguinte post do stack overflow
https://stackoverflow.com/questions/41381064/vscode-c-sharp-add-reference-to-custom-assembly
