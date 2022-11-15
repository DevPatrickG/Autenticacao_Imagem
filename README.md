<h1> Autenticação de Imagem. APS - 6° Semestre </h1> 
<h2> Esse projeto é sobre Autenticação por imagem. <br> Se baseia em contar a númeração da colocaração da cada pixel da imagem, ou seja, é 100% precisa, pois se tiver uma númeração diferente, a autenticação não ocorre. <br> Para iniciarmos, primeiramente devemos realizar algumas configurações de banco de dados. </h2>
<h3> 1° Deve ter SQL Server instalado na máquina. De preferência o Microsoft SQL Server Management Studio 2018 </h3>
<h3> 2° Deve Criar um banco de dados com o Nome "Autenticidade" </h3> 
<div>
  <img src="https://user-images.githubusercontent.com/106789317/201944906-e391bfcd-b808-4ac7-8fb5-97d316e2194a.PNG"
</div>
  <h3> 3° Deve Executar esse seguinte Script: </h3>
<div>
USE [Autenticidade] <br>
GO <br>
/****** Object:  Table [dbo].[Acesso_Biometrico]    Script Date: 13/11/2022 19:33:43 ******/<br>
SET ANSI_NULLS ON <br>
GO <br>
SET QUOTED_IDENTIFIER ON <br>
GO <br>
CREATE TABLE [dbo].[Acesso_Biometrico]( <br>
	[Nome_Usuario] [varchar](50) NOT NULL, <br>
	[Usuario] [int] NOT NULL, <br> 
	[Cod_Biometrico] [text] NOT NULL, <br>
 CONSTRAINT [PK_Acesso_Biometrico] PRIMARY KEY CLUSTERED <br>
( <br>
	[Nome_Usuario] ASC <br>
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY] 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY] <br>
GO
<h3> Após, deve ir no Projeto, na classe "clsConexao" na Linha 14 e mudar o caminho da conexão para o caminho de conexão do banco de sua máquina: </h3>
<div>
<img src="https://user-images.githubusercontent.com/106789317/201972331-42d23357-879d-4b70-b5e1-4f7a9a09f1a3.PNG"
</div>
</div>
<h2> Após Executar o Script, o Programa estará pronto para uso. Suas funcionalidades serão mostradas. </h2>
<div>
<h3> Essa é a tela Principal: <h3>
<img src="https://user-images.githubusercontent.com/106789317/201951178-3fd6d0f8-fa6b-4f89-bd35-6f259a291677.PNG"<br>
<h3>° "Cadastro Para Acesso": Essa tela é para cadastrar o usuário com imagem para depois autenticar. </h3>
<h3>° "Informações Nivel 1": Essa tela é uma tela com informações livres, não necessitando de autenticação.</h3>
<h3>° "Informações Nivel 2": Essa tela necessita de autenticação. Deve existir cadastro de "Diretor de Divisão".</h3>
<h3>° "Informações Nivel 3": Essa tela necessita de autenticação. Deve existir cadastro de "Ministro do meio Ambiente".</h3>
</div>

	
<h4> Tela "Cadastro Para Acesso" <h4>
<img src="https://user-images.githubusercontent.com/106789317/201951851-7611c984-9886-4982-ad8f-ef989b2068b9.PNG"
     
<h3> <br> 4° Nessa tela, deve cadastrar o perfil de Autenticidade. <br> <br>
° Primeiro deve informar o Nome do Usuário <br> <br>
° Segundo, escolher qual é o tipo de perfil do mesmo, como está informado na checkbox: <br> "Diretor de Divisão" ou Ministro do "Meio Ambiente". <br> <br>
° Após, deve anexar uma imagem para autenticação. Lembrando que a Imagem deve ter Dimensões 300px height/ 300px width. É obrigatório ter esse padrão! <br> <br>
° Na Pasta "Imagens" que está versionada no Projeto. Deixei 4 Imagens com Dimensões 300px / 300px. Podem usar-las:<br>
<img src="https://user-images.githubusercontent.com/106789317/201955473-3c5d8259-e567-4165-90d8-9ef7bb364416.PNG" <br><br>
5° Será mostrado um exemplo de como manusear o sistema. Primeiro Efetuei um Cadastro "TESTE" como Perfil Ministro do Meio Ambiente, como está processando: <br></h3>
<div> <img src="https://user-images.githubusercontent.com/106789317/201959363-ba7a2191-0556-4d4a-aab8-b1cf37247a40.PNG" <br> 
<h3> E a Inserção foi um Sucesso! </h3>
<div> <img src="https://user-images.githubusercontent.com/106789317/201958689-935feb6e-a61a-4ad3-82ed-711e321861c1.PNG" </div>
</div>
<h3> Após, devo retornar ao menu principal e ir na Tela :"Informações Nivel 3", pois o meu cadastro foi do tipo de Perfil "Ministro do meio Ambiente"</h3>
<h3> 6° Como mostra na imagem a seguir, informo o mesmo nome e a mesma imagem que cadastrei no exemplo 5: </h3>
<div>
<img src="https://user-images.githubusercontent.com/106789317/201967460-51082c3f-b15e-4381-8b7d-74b7aae4ee6d.PNG"
</div>
<h3> A Autenticação foi um Sucesso:
<div> <img src="https://user-images.githubusercontent.com/106789317/201968624-11934dc8-a66b-4aa7-9611-763f76c84c88.PNG" </div>
<h3>Esse foi o exemplo de funcionalidade do sistema.<br> Obs: Caso efetuar um cadastro de usuário de "Diretor de Divisão". A Autenticação deve ocorrer na tela :"Informações Nivel 2" </h3>

