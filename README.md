<h1> Autenticação de Imagem. APS - 6° Semestre </h1> 
<h2> Esse projeto é sobre efetuar autenticação por imagem. Para iniciarmos, primeiramente devemos realizar algumas configurações de banco de dados. </h2>
<h3> 1° Deve ter SQL Server instalado na máquina. De preferência o Microsoft SQL Server Management Studio 2018 </h3>
<h3> 2° Deve Criar um banco de dados com o Nome "Autenticidade" </h3>
<div>
  <img src="https://user-images.githubusercontent.com/106789317/201944906-e391bfcd-b808-4ac7-8fb5-97d316e2194a.PNG"
</div>
  <h3> 3° Deve Executar esse seguinte Script: </h3>
<div>
USE [Autenticidade]
GO
/****** Object:  Table [dbo].[Acesso_Biometrico]    Script Date: 13/11/2022 19:33:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Acesso_Biometrico](
	[Nome_Usuario] [varchar](50) NOT NULL,
	[Usuario] [int] NOT NULL,
	[Cod_Biometrico] [text] NOT NULL,
 CONSTRAINT [PK_Acesso_Biometrico] PRIMARY KEY CLUSTERED 
(
	[Nome_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
	
</div>
