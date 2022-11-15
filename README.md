<h1> Autenticação de Imagem. APS - 6° Semestre </h1> 
<h2> Esse projeto é sobre efetuar autenticação por imagem. Para iniciarmos, primeiramente devemos realizar algumas configurações de banco de dados. </h2>
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
	
</div>
<h2> Após Executar o Script, o Programa estará pronto para uso. Suas funcionalidades serão mostradas. </h2>
<div>
<h3> Essa é a tela Principal: <h3>
<img src="https://user-images.githubusercontent.com/106789317/201951178-3fd6d0f8-fa6b-4f89-bd35-6f259a291677.PNG"
</div>
<div>
	
<h4> Tela "Cadastro Para Acesso" <h4>
<img src="https://user-images.githubusercontent.com/106789317/201951851-7611c984-9886-4982-ad8f-ef989b2068b9.PNG"
<h3> <br> 4° Nessa tela, deve cadastrar o perfil de Autenticidade. <br> <br>
° Primeiro deve informar o Nome do Usuário <br> <br>
° Segundo, escolher qual é o tipo de perfil do mesmo, como está informado na checkbox: <br> "Diretor de Divisão" ou Ministro do "Meio Ambiente". <br> <br>
° Após, deve anexar uma imagem para autenticação. Lembrando que a Imagem deve ter Dimensões 300px height/ 300px width, para seguir o padrão <br> <br>
° Na Pasta "Imagens" que está versionada no Projeto. Deixei 4 Imagens com Dimensões 300px / 300px. Podem usar-las: </h3>
</div>
