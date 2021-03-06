USE [isletimdb]
GO
/****** Object:  Table [dbo].[kullanicilar]    Script Date: 15.05.2016 20:25:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kullanicilar](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nvarchar](50) NOT NULL,
	[soyad] [nvarchar](50) NOT NULL,
	[kullanici_ad] [nvarchar](50) NOT NULL,
	[sifre] [nvarchar](50) NOT NULL,
	[mail] [nvarchar](50) NOT NULL,
	[dogum_tarih] [date] NOT NULL,
	[aktif_durum] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_kullanicilar] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[mesajlar]    Script Date: 15.05.2016 20:25:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mesajlar](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[gonderen_id] [int] NOT NULL,
	[alan_id] [int] NOT NULL,
	[mesaj] [text] NOT NULL,
	[tarih] [datetime] NULL CONSTRAINT [DF_mesajlar_tarih]  DEFAULT (getdate()),
	[okundu] [int] NOT NULL,
 CONSTRAINT [PK_mesajlar] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[silinenmesajlar]    Script Date: 15.05.2016 20:25:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[silinenmesajlar](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[silen_kullanici_id] [int] NULL,
	[silinen_kullanici_id] [int] NULL,
	[tarih] [datetime] NULL,
 CONSTRAINT [PK_silinenmesajlar] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
