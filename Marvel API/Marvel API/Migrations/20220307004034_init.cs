using Microsoft.EntityFrameworkCore.Migrations;

namespace Marvel_API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Champion",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    blurb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    partype = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Champion", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "imageSpells",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    full = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sprite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    group = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    x = table.Column<double>(type: "float", nullable: false),
                    y = table.Column<double>(type: "float", nullable: false),
                    w = table.Column<double>(type: "float", nullable: false),
                    h = table.Column<double>(type: "float", nullable: false),
                    SpellsId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_imageSpells", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "allytypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChampionId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_allytypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_allytypes_Champion_ChampionId",
                        column: x => x.ChampionId,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Champions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aatroxid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Ahriid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Akaliid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Alistarid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Amumuid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Aniviaid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Annieid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Apheliosid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Asheid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AurelionSolid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Azirid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Bardid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Blitzcrankid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Brandid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Braumid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Caitlynid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Camilleid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Cassiopeiaid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Chogathid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Corkiid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Dariusid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Dianaid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DrMundoid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Dravenid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Ekkoid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Eliseid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Evelynnid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Ezrealid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Fiddlesticksid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Fioraid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Fizzid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Galioid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Gangplankid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Garenid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Gnarid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Gragasid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Gravesid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Hecarimid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Heimerdingerid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Illaoiid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Ireliaid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Ivernid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Jannaid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    JarvanIVid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Jaxid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Jayceid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Jhinid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Jinxid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    KaiSaid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Kalistaid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Karmaid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Karthusid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Kassadinid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Katarinaid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Kayleid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Kaynid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Kennenid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Khazixid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Kindredid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Kledid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    KogMawid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LeBlancid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LeeSinid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Leonaid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Lilliaid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Lissandraid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Lucianid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Luluid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Luxid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Malphiteid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Malzaharid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Maokaiid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MasterYiid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MissFortuneid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Mordekaiserid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Morganaid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Namiid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Nasusid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Nautilusid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Neekoid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Nidaleeid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Nocturneid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Nunuid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Olafid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Oriannaid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Ornnid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Pantheonid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Poppyid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Pykeid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Qiyanaid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Quinnid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Rakanid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Rammusid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    RekSaiid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Rellid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Renektonid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Rengarid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Rivenid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Rumbleid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Ryzeid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Samiraid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Sejuaniid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Sennaid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Seraphineid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Settid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Shacoid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Shenid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Shyvanaid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Singedid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Sionid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Sivirid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Skarnerid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Sonaid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Sorakaid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Swainid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Sylasid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Syndraid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TahmKenchid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Taliyahid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Talonid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Taricid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Teemoid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Threshid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Tristanaid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Trundleid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Tryndamereid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TwistedFateid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Twitchid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Udyrid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Urgotid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Varusid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Vayneid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Veigarid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    VelKozid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Viid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Viegoid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Viktorid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Vladimirid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Volibearid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Warwickid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MonkeyKingid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Xayahid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Xerathid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    XinZhaoid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Yasuoid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Yoneid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Yorickid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Yuumiid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Zacid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Zedid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Ziggsid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Zileanid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Zoeid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Zyraid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Champions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Aatroxid",
                        column: x => x.Aatroxid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Ahriid",
                        column: x => x.Ahriid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Akaliid",
                        column: x => x.Akaliid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Alistarid",
                        column: x => x.Alistarid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Amumuid",
                        column: x => x.Amumuid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Aniviaid",
                        column: x => x.Aniviaid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Annieid",
                        column: x => x.Annieid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Apheliosid",
                        column: x => x.Apheliosid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Asheid",
                        column: x => x.Asheid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_AurelionSolid",
                        column: x => x.AurelionSolid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Azirid",
                        column: x => x.Azirid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Bardid",
                        column: x => x.Bardid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Blitzcrankid",
                        column: x => x.Blitzcrankid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Brandid",
                        column: x => x.Brandid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Braumid",
                        column: x => x.Braumid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Caitlynid",
                        column: x => x.Caitlynid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Camilleid",
                        column: x => x.Camilleid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Cassiopeiaid",
                        column: x => x.Cassiopeiaid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Chogathid",
                        column: x => x.Chogathid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Corkiid",
                        column: x => x.Corkiid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Dariusid",
                        column: x => x.Dariusid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Dianaid",
                        column: x => x.Dianaid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Dravenid",
                        column: x => x.Dravenid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_DrMundoid",
                        column: x => x.DrMundoid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Ekkoid",
                        column: x => x.Ekkoid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Eliseid",
                        column: x => x.Eliseid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Evelynnid",
                        column: x => x.Evelynnid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Ezrealid",
                        column: x => x.Ezrealid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Fiddlesticksid",
                        column: x => x.Fiddlesticksid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Fioraid",
                        column: x => x.Fioraid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Fizzid",
                        column: x => x.Fizzid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Galioid",
                        column: x => x.Galioid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Gangplankid",
                        column: x => x.Gangplankid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Garenid",
                        column: x => x.Garenid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Gnarid",
                        column: x => x.Gnarid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Gragasid",
                        column: x => x.Gragasid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Gravesid",
                        column: x => x.Gravesid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Hecarimid",
                        column: x => x.Hecarimid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Heimerdingerid",
                        column: x => x.Heimerdingerid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Illaoiid",
                        column: x => x.Illaoiid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Ireliaid",
                        column: x => x.Ireliaid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Ivernid",
                        column: x => x.Ivernid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Jannaid",
                        column: x => x.Jannaid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_JarvanIVid",
                        column: x => x.JarvanIVid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Jaxid",
                        column: x => x.Jaxid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Jayceid",
                        column: x => x.Jayceid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Jhinid",
                        column: x => x.Jhinid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Jinxid",
                        column: x => x.Jinxid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_KaiSaid",
                        column: x => x.KaiSaid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Kalistaid",
                        column: x => x.Kalistaid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Karmaid",
                        column: x => x.Karmaid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Karthusid",
                        column: x => x.Karthusid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Kassadinid",
                        column: x => x.Kassadinid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Katarinaid",
                        column: x => x.Katarinaid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Kayleid",
                        column: x => x.Kayleid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Kaynid",
                        column: x => x.Kaynid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Kennenid",
                        column: x => x.Kennenid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Khazixid",
                        column: x => x.Khazixid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Kindredid",
                        column: x => x.Kindredid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Kledid",
                        column: x => x.Kledid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_KogMawid",
                        column: x => x.KogMawid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_LeBlancid",
                        column: x => x.LeBlancid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_LeeSinid",
                        column: x => x.LeeSinid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Leonaid",
                        column: x => x.Leonaid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Lilliaid",
                        column: x => x.Lilliaid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Lissandraid",
                        column: x => x.Lissandraid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Lucianid",
                        column: x => x.Lucianid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Luluid",
                        column: x => x.Luluid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Luxid",
                        column: x => x.Luxid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Malphiteid",
                        column: x => x.Malphiteid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Malzaharid",
                        column: x => x.Malzaharid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Maokaiid",
                        column: x => x.Maokaiid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_MasterYiid",
                        column: x => x.MasterYiid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_MissFortuneid",
                        column: x => x.MissFortuneid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_MonkeyKingid",
                        column: x => x.MonkeyKingid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Mordekaiserid",
                        column: x => x.Mordekaiserid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Morganaid",
                        column: x => x.Morganaid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Namiid",
                        column: x => x.Namiid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Nasusid",
                        column: x => x.Nasusid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Nautilusid",
                        column: x => x.Nautilusid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Neekoid",
                        column: x => x.Neekoid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Nidaleeid",
                        column: x => x.Nidaleeid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Nocturneid",
                        column: x => x.Nocturneid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Nunuid",
                        column: x => x.Nunuid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Olafid",
                        column: x => x.Olafid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Oriannaid",
                        column: x => x.Oriannaid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Ornnid",
                        column: x => x.Ornnid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Pantheonid",
                        column: x => x.Pantheonid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Poppyid",
                        column: x => x.Poppyid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Pykeid",
                        column: x => x.Pykeid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Qiyanaid",
                        column: x => x.Qiyanaid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Quinnid",
                        column: x => x.Quinnid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Rakanid",
                        column: x => x.Rakanid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Rammusid",
                        column: x => x.Rammusid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_RekSaiid",
                        column: x => x.RekSaiid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Rellid",
                        column: x => x.Rellid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Renektonid",
                        column: x => x.Renektonid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Rengarid",
                        column: x => x.Rengarid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Rivenid",
                        column: x => x.Rivenid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Rumbleid",
                        column: x => x.Rumbleid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Ryzeid",
                        column: x => x.Ryzeid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Samiraid",
                        column: x => x.Samiraid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Sejuaniid",
                        column: x => x.Sejuaniid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Sennaid",
                        column: x => x.Sennaid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Seraphineid",
                        column: x => x.Seraphineid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Settid",
                        column: x => x.Settid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Shacoid",
                        column: x => x.Shacoid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Shenid",
                        column: x => x.Shenid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Shyvanaid",
                        column: x => x.Shyvanaid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Singedid",
                        column: x => x.Singedid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Sionid",
                        column: x => x.Sionid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Sivirid",
                        column: x => x.Sivirid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Skarnerid",
                        column: x => x.Skarnerid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Sonaid",
                        column: x => x.Sonaid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Sorakaid",
                        column: x => x.Sorakaid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Swainid",
                        column: x => x.Swainid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Sylasid",
                        column: x => x.Sylasid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Syndraid",
                        column: x => x.Syndraid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_TahmKenchid",
                        column: x => x.TahmKenchid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Taliyahid",
                        column: x => x.Taliyahid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Talonid",
                        column: x => x.Talonid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Taricid",
                        column: x => x.Taricid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Teemoid",
                        column: x => x.Teemoid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Threshid",
                        column: x => x.Threshid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Tristanaid",
                        column: x => x.Tristanaid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Trundleid",
                        column: x => x.Trundleid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Tryndamereid",
                        column: x => x.Tryndamereid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_TwistedFateid",
                        column: x => x.TwistedFateid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Twitchid",
                        column: x => x.Twitchid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Udyrid",
                        column: x => x.Udyrid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Urgotid",
                        column: x => x.Urgotid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Varusid",
                        column: x => x.Varusid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Vayneid",
                        column: x => x.Vayneid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Veigarid",
                        column: x => x.Veigarid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_VelKozid",
                        column: x => x.VelKozid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Viegoid",
                        column: x => x.Viegoid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Viid",
                        column: x => x.Viid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Viktorid",
                        column: x => x.Viktorid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Vladimirid",
                        column: x => x.Vladimirid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Volibearid",
                        column: x => x.Volibearid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Warwickid",
                        column: x => x.Warwickid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Xayahid",
                        column: x => x.Xayahid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Xerathid",
                        column: x => x.Xerathid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_XinZhaoid",
                        column: x => x.XinZhaoid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Yasuoid",
                        column: x => x.Yasuoid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Yoneid",
                        column: x => x.Yoneid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Yorickid",
                        column: x => x.Yorickid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Yuumiid",
                        column: x => x.Yuumiid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Zacid",
                        column: x => x.Zacid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Zedid",
                        column: x => x.Zedid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Ziggsid",
                        column: x => x.Ziggsid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Zileanid",
                        column: x => x.Zileanid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Zoeid",
                        column: x => x.Zoeid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_Champion_Zyraid",
                        column: x => x.Zyraid,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "enemyytypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChampionId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_enemyytypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_enemyytypes_Champion_ChampionId",
                        column: x => x.ChampionId,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "image",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    full = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sprite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    group = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    x = table.Column<double>(type: "float", nullable: false),
                    y = table.Column<double>(type: "float", nullable: false),
                    w = table.Column<double>(type: "float", nullable: false),
                    h = table.Column<double>(type: "float", nullable: false),
                    ChampionId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_image", x => x.Id);
                    table.ForeignKey(
                        name: "FK_image_Champion_ChampionId",
                        column: x => x.ChampionId,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "info",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    attack = table.Column<int>(type: "int", nullable: false),
                    defense = table.Column<int>(type: "int", nullable: false),
                    magic = table.Column<int>(type: "int", nullable: false),
                    difficulty = table.Column<int>(type: "int", nullable: false),
                    ChampionId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_info", x => x.Id);
                    table.ForeignKey(
                        name: "FK_info_Champion_ChampionId",
                        column: x => x.ChampionId,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "passive",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChampionId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_passive", x => x.Id);
                    table.ForeignKey(
                        name: "FK_passive_Champion_ChampionId",
                        column: x => x.ChampionId,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hp = table.Column<double>(type: "float", nullable: false),
                    hpperlevel = table.Column<double>(type: "float", nullable: false),
                    mp = table.Column<double>(type: "float", nullable: false),
                    mpperlevel = table.Column<double>(type: "float", nullable: false),
                    movespeed = table.Column<double>(type: "float", nullable: false),
                    armor = table.Column<double>(type: "float", nullable: false),
                    armorperlevel = table.Column<double>(type: "float", nullable: false),
                    spellblock = table.Column<double>(type: "float", nullable: false),
                    spellblockperlevel = table.Column<double>(type: "float", nullable: false),
                    attackrange = table.Column<double>(type: "float", nullable: false),
                    hpregen = table.Column<double>(type: "float", nullable: false),
                    hpregenperlevel = table.Column<double>(type: "float", nullable: false),
                    mpregen = table.Column<double>(type: "float", nullable: false),
                    mpregenperlevel = table.Column<double>(type: "float", nullable: false),
                    crit = table.Column<double>(type: "float", nullable: false),
                    critperlevel = table.Column<double>(type: "float", nullable: false),
                    attackdamage = table.Column<double>(type: "float", nullable: false),
                    attackdamageperlevel = table.Column<double>(type: "float", nullable: false),
                    attackspeed = table.Column<double>(type: "float", nullable: false),
                    attackspeedperlevel = table.Column<double>(type: "float", nullable: false),
                    ChampionId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stats_Champion_ChampionId",
                        column: x => x.ChampionId,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChampionId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tags_Champion_ChampionId",
                        column: x => x.ChampionId,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "spells",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tooltip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imageId = table.Column<int>(type: "int", nullable: true),
                    ChampionId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_spells", x => x.id);
                    table.ForeignKey(
                        name: "FK_spells_Champion_ChampionId",
                        column: x => x.ChampionId,
                        principalTable: "Champion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_spells_image_imageId",
                        column: x => x.imageId,
                        principalTable: "image",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "imagePassive",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    full = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sprite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    group = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    x = table.Column<double>(type: "float", nullable: false),
                    y = table.Column<double>(type: "float", nullable: false),
                    w = table.Column<double>(type: "float", nullable: false),
                    h = table.Column<double>(type: "float", nullable: false),
                    PassiveId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_imagePassive", x => x.Id);
                    table.ForeignKey(
                        name: "FK_imagePassive_passive_PassiveId",
                        column: x => x.PassiveId,
                        principalTable: "passive",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_allytypes_ChampionId",
                table: "allytypes",
                column: "ChampionId");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Aatroxid",
                table: "Champions",
                column: "Aatroxid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Ahriid",
                table: "Champions",
                column: "Ahriid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Akaliid",
                table: "Champions",
                column: "Akaliid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Alistarid",
                table: "Champions",
                column: "Alistarid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Amumuid",
                table: "Champions",
                column: "Amumuid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Aniviaid",
                table: "Champions",
                column: "Aniviaid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Annieid",
                table: "Champions",
                column: "Annieid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Apheliosid",
                table: "Champions",
                column: "Apheliosid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Asheid",
                table: "Champions",
                column: "Asheid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_AurelionSolid",
                table: "Champions",
                column: "AurelionSolid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Azirid",
                table: "Champions",
                column: "Azirid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Bardid",
                table: "Champions",
                column: "Bardid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Blitzcrankid",
                table: "Champions",
                column: "Blitzcrankid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Brandid",
                table: "Champions",
                column: "Brandid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Braumid",
                table: "Champions",
                column: "Braumid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Caitlynid",
                table: "Champions",
                column: "Caitlynid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Camilleid",
                table: "Champions",
                column: "Camilleid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Cassiopeiaid",
                table: "Champions",
                column: "Cassiopeiaid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Chogathid",
                table: "Champions",
                column: "Chogathid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Corkiid",
                table: "Champions",
                column: "Corkiid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Dariusid",
                table: "Champions",
                column: "Dariusid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Dianaid",
                table: "Champions",
                column: "Dianaid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Dravenid",
                table: "Champions",
                column: "Dravenid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_DrMundoid",
                table: "Champions",
                column: "DrMundoid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Ekkoid",
                table: "Champions",
                column: "Ekkoid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Eliseid",
                table: "Champions",
                column: "Eliseid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Evelynnid",
                table: "Champions",
                column: "Evelynnid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Ezrealid",
                table: "Champions",
                column: "Ezrealid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Fiddlesticksid",
                table: "Champions",
                column: "Fiddlesticksid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Fioraid",
                table: "Champions",
                column: "Fioraid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Fizzid",
                table: "Champions",
                column: "Fizzid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Galioid",
                table: "Champions",
                column: "Galioid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Gangplankid",
                table: "Champions",
                column: "Gangplankid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Garenid",
                table: "Champions",
                column: "Garenid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Gnarid",
                table: "Champions",
                column: "Gnarid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Gragasid",
                table: "Champions",
                column: "Gragasid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Gravesid",
                table: "Champions",
                column: "Gravesid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Hecarimid",
                table: "Champions",
                column: "Hecarimid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Heimerdingerid",
                table: "Champions",
                column: "Heimerdingerid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Illaoiid",
                table: "Champions",
                column: "Illaoiid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Ireliaid",
                table: "Champions",
                column: "Ireliaid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Ivernid",
                table: "Champions",
                column: "Ivernid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Jannaid",
                table: "Champions",
                column: "Jannaid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_JarvanIVid",
                table: "Champions",
                column: "JarvanIVid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Jaxid",
                table: "Champions",
                column: "Jaxid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Jayceid",
                table: "Champions",
                column: "Jayceid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Jhinid",
                table: "Champions",
                column: "Jhinid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Jinxid",
                table: "Champions",
                column: "Jinxid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_KaiSaid",
                table: "Champions",
                column: "KaiSaid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Kalistaid",
                table: "Champions",
                column: "Kalistaid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Karmaid",
                table: "Champions",
                column: "Karmaid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Karthusid",
                table: "Champions",
                column: "Karthusid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Kassadinid",
                table: "Champions",
                column: "Kassadinid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Katarinaid",
                table: "Champions",
                column: "Katarinaid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Kayleid",
                table: "Champions",
                column: "Kayleid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Kaynid",
                table: "Champions",
                column: "Kaynid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Kennenid",
                table: "Champions",
                column: "Kennenid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Khazixid",
                table: "Champions",
                column: "Khazixid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Kindredid",
                table: "Champions",
                column: "Kindredid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Kledid",
                table: "Champions",
                column: "Kledid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_KogMawid",
                table: "Champions",
                column: "KogMawid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_LeBlancid",
                table: "Champions",
                column: "LeBlancid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_LeeSinid",
                table: "Champions",
                column: "LeeSinid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Leonaid",
                table: "Champions",
                column: "Leonaid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Lilliaid",
                table: "Champions",
                column: "Lilliaid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Lissandraid",
                table: "Champions",
                column: "Lissandraid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Lucianid",
                table: "Champions",
                column: "Lucianid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Luluid",
                table: "Champions",
                column: "Luluid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Luxid",
                table: "Champions",
                column: "Luxid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Malphiteid",
                table: "Champions",
                column: "Malphiteid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Malzaharid",
                table: "Champions",
                column: "Malzaharid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Maokaiid",
                table: "Champions",
                column: "Maokaiid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_MasterYiid",
                table: "Champions",
                column: "MasterYiid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_MissFortuneid",
                table: "Champions",
                column: "MissFortuneid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_MonkeyKingid",
                table: "Champions",
                column: "MonkeyKingid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Mordekaiserid",
                table: "Champions",
                column: "Mordekaiserid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Morganaid",
                table: "Champions",
                column: "Morganaid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Namiid",
                table: "Champions",
                column: "Namiid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Nasusid",
                table: "Champions",
                column: "Nasusid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Nautilusid",
                table: "Champions",
                column: "Nautilusid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Neekoid",
                table: "Champions",
                column: "Neekoid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Nidaleeid",
                table: "Champions",
                column: "Nidaleeid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Nocturneid",
                table: "Champions",
                column: "Nocturneid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Nunuid",
                table: "Champions",
                column: "Nunuid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Olafid",
                table: "Champions",
                column: "Olafid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Oriannaid",
                table: "Champions",
                column: "Oriannaid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Ornnid",
                table: "Champions",
                column: "Ornnid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Pantheonid",
                table: "Champions",
                column: "Pantheonid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Poppyid",
                table: "Champions",
                column: "Poppyid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Pykeid",
                table: "Champions",
                column: "Pykeid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Qiyanaid",
                table: "Champions",
                column: "Qiyanaid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Quinnid",
                table: "Champions",
                column: "Quinnid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Rakanid",
                table: "Champions",
                column: "Rakanid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Rammusid",
                table: "Champions",
                column: "Rammusid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_RekSaiid",
                table: "Champions",
                column: "RekSaiid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Rellid",
                table: "Champions",
                column: "Rellid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Renektonid",
                table: "Champions",
                column: "Renektonid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Rengarid",
                table: "Champions",
                column: "Rengarid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Rivenid",
                table: "Champions",
                column: "Rivenid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Rumbleid",
                table: "Champions",
                column: "Rumbleid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Ryzeid",
                table: "Champions",
                column: "Ryzeid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Samiraid",
                table: "Champions",
                column: "Samiraid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Sejuaniid",
                table: "Champions",
                column: "Sejuaniid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Sennaid",
                table: "Champions",
                column: "Sennaid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Seraphineid",
                table: "Champions",
                column: "Seraphineid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Settid",
                table: "Champions",
                column: "Settid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Shacoid",
                table: "Champions",
                column: "Shacoid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Shenid",
                table: "Champions",
                column: "Shenid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Shyvanaid",
                table: "Champions",
                column: "Shyvanaid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Singedid",
                table: "Champions",
                column: "Singedid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Sionid",
                table: "Champions",
                column: "Sionid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Sivirid",
                table: "Champions",
                column: "Sivirid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Skarnerid",
                table: "Champions",
                column: "Skarnerid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Sonaid",
                table: "Champions",
                column: "Sonaid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Sorakaid",
                table: "Champions",
                column: "Sorakaid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Swainid",
                table: "Champions",
                column: "Swainid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Sylasid",
                table: "Champions",
                column: "Sylasid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Syndraid",
                table: "Champions",
                column: "Syndraid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_TahmKenchid",
                table: "Champions",
                column: "TahmKenchid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Taliyahid",
                table: "Champions",
                column: "Taliyahid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Talonid",
                table: "Champions",
                column: "Talonid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Taricid",
                table: "Champions",
                column: "Taricid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Teemoid",
                table: "Champions",
                column: "Teemoid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Threshid",
                table: "Champions",
                column: "Threshid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Tristanaid",
                table: "Champions",
                column: "Tristanaid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Trundleid",
                table: "Champions",
                column: "Trundleid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Tryndamereid",
                table: "Champions",
                column: "Tryndamereid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_TwistedFateid",
                table: "Champions",
                column: "TwistedFateid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Twitchid",
                table: "Champions",
                column: "Twitchid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Udyrid",
                table: "Champions",
                column: "Udyrid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Urgotid",
                table: "Champions",
                column: "Urgotid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Varusid",
                table: "Champions",
                column: "Varusid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Vayneid",
                table: "Champions",
                column: "Vayneid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Veigarid",
                table: "Champions",
                column: "Veigarid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_VelKozid",
                table: "Champions",
                column: "VelKozid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Viegoid",
                table: "Champions",
                column: "Viegoid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Viid",
                table: "Champions",
                column: "Viid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Viktorid",
                table: "Champions",
                column: "Viktorid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Vladimirid",
                table: "Champions",
                column: "Vladimirid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Volibearid",
                table: "Champions",
                column: "Volibearid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Warwickid",
                table: "Champions",
                column: "Warwickid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Xayahid",
                table: "Champions",
                column: "Xayahid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Xerathid",
                table: "Champions",
                column: "Xerathid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_XinZhaoid",
                table: "Champions",
                column: "XinZhaoid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Yasuoid",
                table: "Champions",
                column: "Yasuoid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Yoneid",
                table: "Champions",
                column: "Yoneid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Yorickid",
                table: "Champions",
                column: "Yorickid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Yuumiid",
                table: "Champions",
                column: "Yuumiid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Zacid",
                table: "Champions",
                column: "Zacid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Zedid",
                table: "Champions",
                column: "Zedid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Ziggsid",
                table: "Champions",
                column: "Ziggsid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Zileanid",
                table: "Champions",
                column: "Zileanid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Zoeid",
                table: "Champions",
                column: "Zoeid");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_Zyraid",
                table: "Champions",
                column: "Zyraid");

            migrationBuilder.CreateIndex(
                name: "IX_enemyytypes_ChampionId",
                table: "enemyytypes",
                column: "ChampionId");

            migrationBuilder.CreateIndex(
                name: "IX_image_ChampionId",
                table: "image",
                column: "ChampionId",
                unique: true,
                filter: "[ChampionId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_imagePassive_PassiveId",
                table: "imagePassive",
                column: "PassiveId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_info_ChampionId",
                table: "info",
                column: "ChampionId",
                unique: true,
                filter: "[ChampionId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_passive_ChampionId",
                table: "passive",
                column: "ChampionId",
                unique: true,
                filter: "[ChampionId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_spells_ChampionId",
                table: "spells",
                column: "ChampionId");

            migrationBuilder.CreateIndex(
                name: "IX_spells_imageId",
                table: "spells",
                column: "imageId");

            migrationBuilder.CreateIndex(
                name: "IX_Stats_ChampionId",
                table: "Stats",
                column: "ChampionId",
                unique: true,
                filter: "[ChampionId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tags_ChampionId",
                table: "tags",
                column: "ChampionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "allytypes");

            migrationBuilder.DropTable(
                name: "Champions");

            migrationBuilder.DropTable(
                name: "enemyytypes");

            migrationBuilder.DropTable(
                name: "imagePassive");

            migrationBuilder.DropTable(
                name: "imageSpells");

            migrationBuilder.DropTable(
                name: "info");

            migrationBuilder.DropTable(
                name: "spells");

            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.DropTable(
                name: "tags");

            migrationBuilder.DropTable(
                name: "passive");

            migrationBuilder.DropTable(
                name: "image");

            migrationBuilder.DropTable(
                name: "Champion");
        }
    }
}
