//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:/Users/Yurn/RiderProjects/Kotlin/grammar/UnicodeClasses.g4 by ANTLR 4.13.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.2")]
[System.CLSCompliant(false)]
public partial class UnicodeClasses : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		UNICODE_CLASS_LL=1, UNICODE_CLASS_LM=2, UNICODE_CLASS_LO=3, UNICODE_CLASS_LT=4, 
		UNICODE_CLASS_LU=5, UNICODE_CLASS_ND=6, UNICODE_CLASS_NL=7;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"UNICODE_CLASS_LL", "UNICODE_CLASS_LM", "UNICODE_CLASS_LO", "UNICODE_CLASS_LT", 
		"UNICODE_CLASS_LU", "UNICODE_CLASS_ND", "UNICODE_CLASS_NL"
	};


	public UnicodeClasses(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public UnicodeClasses(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
	};
	private static readonly string[] _SymbolicNames = {
		null, "UNICODE_CLASS_LL", "UNICODE_CLASS_LM", "UNICODE_CLASS_LO", "UNICODE_CLASS_LT", 
		"UNICODE_CLASS_LU", "UNICODE_CLASS_ND", "UNICODE_CLASS_NL"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "UnicodeClasses.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static UnicodeClasses() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,7,29,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,6,
		1,0,1,0,1,1,1,1,1,2,1,2,1,3,1,3,1,4,1,4,1,5,1,5,1,6,1,6,0,0,7,1,1,3,2,
		5,3,7,4,9,5,11,6,13,7,1,0,7,582,0,97,122,181,181,223,246,248,255,257,257,
		259,259,261,261,263,263,265,265,267,267,269,269,271,271,273,273,275,275,
		277,277,279,279,281,281,283,283,285,285,287,287,289,289,291,291,293,293,
		295,295,297,297,299,299,301,301,303,303,305,305,307,307,309,309,311,312,
		314,314,316,316,318,318,320,320,322,322,324,324,326,326,328,329,331,331,
		333,333,335,335,337,337,339,339,341,341,343,343,345,345,347,347,349,349,
		351,351,353,353,355,355,357,357,359,359,361,361,363,363,365,365,367,367,
		369,369,371,371,373,373,375,375,378,378,380,380,382,384,387,387,389,389,
		392,392,396,397,402,402,405,405,409,411,414,414,417,417,419,419,421,421,
		424,424,426,427,429,429,432,432,436,436,438,438,441,442,445,447,454,454,
		457,457,460,460,462,462,464,464,466,466,468,468,470,470,472,472,474,474,
		476,477,479,479,481,481,483,483,485,485,487,487,489,489,491,491,493,493,
		495,496,499,499,501,501,505,505,507,507,509,509,511,511,513,513,515,515,
		517,517,519,519,521,521,523,523,525,525,527,527,529,529,531,531,533,533,
		535,535,537,537,539,539,541,541,543,543,545,545,547,547,549,549,551,551,
		553,553,555,555,557,557,559,559,561,561,563,569,572,572,575,576,578,578,
		583,583,585,585,587,587,589,589,591,659,661,687,881,881,883,883,887,887,
		891,893,912,912,940,974,976,977,981,983,985,985,987,987,989,989,991,991,
		993,993,995,995,997,997,999,999,1001,1001,1003,1003,1005,1005,1007,1011,
		1013,1013,1016,1016,1019,1020,1072,1119,1121,1121,1123,1123,1125,1125,
		1127,1127,1129,1129,1131,1131,1133,1133,1135,1135,1137,1137,1139,1139,
		1141,1141,1143,1143,1145,1145,1147,1147,1149,1149,1151,1151,1153,1153,
		1163,1163,1165,1165,1167,1167,1169,1169,1171,1171,1173,1173,1175,1175,
		1177,1177,1179,1179,1181,1181,1183,1183,1185,1185,1187,1187,1189,1189,
		1191,1191,1193,1193,1195,1195,1197,1197,1199,1199,1201,1201,1203,1203,
		1205,1205,1207,1207,1209,1209,1211,1211,1213,1213,1215,1215,1218,1218,
		1220,1220,1222,1222,1224,1224,1226,1226,1228,1228,1230,1231,1233,1233,
		1235,1235,1237,1237,1239,1239,1241,1241,1243,1243,1245,1245,1247,1247,
		1249,1249,1251,1251,1253,1253,1255,1255,1257,1257,1259,1259,1261,1261,
		1263,1263,1265,1265,1267,1267,1269,1269,1271,1271,1273,1273,1275,1275,
		1277,1277,1279,1279,1281,1281,1283,1283,1285,1285,1287,1287,1289,1289,
		1291,1291,1293,1293,1295,1295,1297,1297,1299,1299,1301,1301,1303,1303,
		1305,1305,1307,1307,1309,1309,1311,1311,1313,1313,1315,1315,1317,1317,
		1319,1319,1377,1415,7424,7467,7531,7543,7545,7578,7681,7681,7683,7683,
		7685,7685,7687,7687,7689,7689,7691,7691,7693,7693,7695,7695,7697,7697,
		7699,7699,7701,7701,7703,7703,7705,7705,7707,7707,7709,7709,7711,7711,
		7713,7713,7715,7715,7717,7717,7719,7719,7721,7721,7723,7723,7725,7725,
		7727,7727,7729,7729,7731,7731,7733,7733,7735,7735,7737,7737,7739,7739,
		7741,7741,7743,7743,7745,7745,7747,7747,7749,7749,7751,7751,7753,7753,
		7755,7755,7757,7757,7759,7759,7761,7761,7763,7763,7765,7765,7767,7767,
		7769,7769,7771,7771,7773,7773,7775,7775,7777,7777,7779,7779,7781,7781,
		7783,7783,7785,7785,7787,7787,7789,7789,7791,7791,7793,7793,7795,7795,
		7797,7797,7799,7799,7801,7801,7803,7803,7805,7805,7807,7807,7809,7809,
		7811,7811,7813,7813,7815,7815,7817,7817,7819,7819,7821,7821,7823,7823,
		7825,7825,7827,7827,7829,7837,7839,7839,7841,7841,7843,7843,7845,7845,
		7847,7847,7849,7849,7851,7851,7853,7853,7855,7855,7857,7857,7859,7859,
		7861,7861,7863,7863,7865,7865,7867,7867,7869,7869,7871,7871,7873,7873,
		7875,7875,7877,7877,7879,7879,7881,7881,7883,7883,7885,7885,7887,7887,
		7889,7889,7891,7891,7893,7893,7895,7895,7897,7897,7899,7899,7901,7901,
		7903,7903,7905,7905,7907,7907,7909,7909,7911,7911,7913,7913,7915,7915,
		7917,7917,7919,7919,7921,7921,7923,7923,7925,7925,7927,7927,7929,7929,
		7931,7931,7933,7933,7935,7943,7952,7957,7968,7975,7984,7991,8000,8005,
		8016,8023,8032,8039,8048,8061,8064,8071,8080,8087,8096,8103,8112,8116,
		8118,8119,8126,8126,8130,8132,8134,8135,8144,8147,8150,8151,8160,8167,
		8178,8180,8182,8183,8458,8458,8462,8463,8467,8467,8495,8495,8500,8500,
		8505,8505,8508,8509,8518,8521,8526,8526,8580,8580,11312,11358,11361,11361,
		11365,11366,11368,11368,11370,11370,11372,11372,11377,11377,11379,11380,
		11382,11387,11393,11393,11395,11395,11397,11397,11399,11399,11401,11401,
		11403,11403,11405,11405,11407,11407,11409,11409,11411,11411,11413,11413,
		11415,11415,11417,11417,11419,11419,11421,11421,11423,11423,11425,11425,
		11427,11427,11429,11429,11431,11431,11433,11433,11435,11435,11437,11437,
		11439,11439,11441,11441,11443,11443,11445,11445,11447,11447,11449,11449,
		11451,11451,11453,11453,11455,11455,11457,11457,11459,11459,11461,11461,
		11463,11463,11465,11465,11467,11467,11469,11469,11471,11471,11473,11473,
		11475,11475,11477,11477,11479,11479,11481,11481,11483,11483,11485,11485,
		11487,11487,11489,11489,11491,11492,11500,11500,11502,11502,11507,11507,
		11520,11557,11559,11559,11565,11565,42561,42561,42563,42563,42565,42565,
		42567,42567,42569,42569,42571,42571,42573,42573,42575,42575,42577,42577,
		42579,42579,42581,42581,42583,42583,42585,42585,42587,42587,42589,42589,
		42591,42591,42593,42593,42595,42595,42597,42597,42599,42599,42601,42601,
		42603,42603,42605,42605,42625,42625,42627,42627,42629,42629,42631,42631,
		42633,42633,42635,42635,42637,42637,42639,42639,42641,42641,42643,42643,
		42645,42645,42647,42647,42787,42787,42789,42789,42791,42791,42793,42793,
		42795,42795,42797,42797,42799,42801,42803,42803,42805,42805,42807,42807,
		42809,42809,42811,42811,42813,42813,42815,42815,42817,42817,42819,42819,
		42821,42821,42823,42823,42825,42825,42827,42827,42829,42829,42831,42831,
		42833,42833,42835,42835,42837,42837,42839,42839,42841,42841,42843,42843,
		42845,42845,42847,42847,42849,42849,42851,42851,42853,42853,42855,42855,
		42857,42857,42859,42859,42861,42861,42863,42863,42865,42872,42874,42874,
		42876,42876,42879,42879,42881,42881,42883,42883,42885,42885,42887,42887,
		42892,42892,42894,42894,42897,42897,42899,42899,42913,42913,42915,42915,
		42917,42917,42919,42919,42921,42921,43002,43002,64256,64262,64275,64279,
		65345,65370,51,0,688,705,710,721,736,740,748,748,750,750,884,884,890,890,
		1369,1369,1600,1600,1765,1766,2036,2037,2042,2042,2074,2074,2084,2084,
		2088,2088,2417,2417,3654,3654,3782,3782,4348,4348,6103,6103,6211,6211,
		6823,6823,7288,7293,7468,7530,7544,7544,7579,7615,8305,8305,8319,8319,
		8336,8348,11388,11389,11631,11631,11823,11823,12293,12293,12337,12341,
		12347,12347,12445,12446,12540,12542,40981,40981,42232,42237,42508,42508,
		42623,42623,42775,42783,42864,42864,42888,42888,43000,43001,43471,43471,
		43632,43632,43741,43741,43763,43764,65392,65392,65438,65439,289,0,170,
		170,186,186,443,443,448,451,660,660,1488,1514,1520,1522,1568,1599,1601,
		1610,1646,1647,1649,1747,1749,1749,1774,1775,1786,1788,1791,1791,1808,
		1808,1810,1839,1869,1957,1969,1969,1994,2026,2048,2069,2112,2136,2208,
		2208,2210,2220,2308,2361,2365,2365,2384,2384,2392,2401,2418,2423,2425,
		2431,2437,2444,2447,2448,2451,2472,2474,2480,2482,2482,2486,2489,2493,
		2493,2510,2510,2524,2525,2527,2529,2544,2545,2565,2570,2575,2576,2579,
		2600,2602,2608,2610,2611,2613,2614,2616,2617,2649,2652,2654,2654,2674,
		2676,2693,2701,2703,2705,2707,2728,2730,2736,2738,2739,2741,2745,2749,
		2749,2768,2768,2784,2785,2821,2828,2831,2832,2835,2856,2858,2864,2866,
		2867,2869,2873,2877,2877,2908,2909,2911,2913,2929,2929,2947,2947,2949,
		2954,2958,2960,2962,2965,2969,2970,2972,2972,2974,2975,2979,2980,2984,
		2986,2990,3001,3024,3024,3077,3084,3086,3088,3090,3112,3114,3123,3125,
		3129,3133,3133,3160,3161,3168,3169,3205,3212,3214,3216,3218,3240,3242,
		3251,3253,3257,3261,3261,3294,3294,3296,3297,3313,3314,3333,3340,3342,
		3344,3346,3386,3389,3389,3406,3406,3424,3425,3450,3455,3461,3478,3482,
		3505,3507,3515,3517,3517,3520,3526,3585,3632,3634,3635,3648,3653,3713,
		3714,3716,3716,3719,3720,3722,3722,3725,3725,3732,3735,3737,3743,3745,
		3747,3749,3749,3751,3751,3754,3755,3757,3760,3762,3763,3773,3773,3776,
		3780,3804,3807,3840,3840,3904,3911,3913,3948,3976,3980,4096,4138,4159,
		4159,4176,4181,4186,4189,4193,4193,4197,4198,4206,4208,4213,4225,4238,
		4238,4304,4346,4349,4680,4682,4685,4688,4694,4696,4696,4698,4701,4704,
		4744,4746,4749,4752,4784,4786,4789,4792,4798,4800,4800,4802,4805,4808,
		4822,4824,4880,4882,4885,4888,4954,4992,5007,5024,5108,5121,5740,5743,
		5759,5761,5786,5792,5866,5888,5900,5902,5905,5920,5937,5952,5969,5984,
		5996,5998,6000,6016,6067,6108,6108,6176,6210,6212,6263,6272,6312,6314,
		6314,6320,6389,6400,6428,6480,6509,6512,6516,6528,6571,6593,6599,6656,
		6678,6688,6740,6917,6963,6981,6987,7043,7072,7086,7087,7098,7141,7168,
		7203,7245,7247,7258,7287,7401,7404,7406,7409,7413,7414,8501,8504,11568,
		11623,11648,11670,11680,11686,11688,11694,11696,11702,11704,11710,11712,
		11718,11720,11726,11728,11734,11736,11742,12294,12294,12348,12348,12353,
		12438,12447,12447,12449,12538,12543,12543,12549,12589,12593,12686,12704,
		12730,12784,12799,13312,13312,19893,19893,19968,19968,40908,40908,40960,
		40980,40982,42124,42192,42231,42240,42507,42512,42527,42538,42539,42606,
		42606,42656,42725,43003,43009,43011,43013,43015,43018,43020,43042,43072,
		43123,43138,43187,43250,43255,43259,43259,43274,43301,43312,43334,43360,
		43388,43396,43442,43520,43560,43584,43586,43588,43595,43616,43631,43633,
		43638,43642,43642,43648,43695,43697,43697,43701,43702,43705,43709,43712,
		43712,43714,43714,43739,43740,43744,43754,43762,43762,43777,43782,43785,
		43790,43793,43798,43808,43814,43816,43822,43968,44002,44032,44032,55203,
		55203,55216,55238,55243,55291,63744,64109,64112,64217,64285,64285,64287,
		64296,64298,64310,64312,64316,64318,64318,64320,64321,64323,64324,64326,
		64433,64467,64829,64848,64911,64914,64967,65008,65019,65136,65140,65142,
		65276,65382,65391,65393,65437,65440,65470,65474,65479,65482,65487,65490,
		65495,65498,65500,10,0,453,453,456,456,459,459,498,498,8072,8079,8088,
		8095,8104,8111,8124,8124,8140,8140,8188,8188,576,0,65,90,192,214,216,222,
		256,256,258,258,260,260,262,262,264,264,266,266,268,268,270,270,272,272,
		274,274,276,276,278,278,280,280,282,282,284,284,286,286,288,288,290,290,
		292,292,294,294,296,296,298,298,300,300,302,302,304,304,306,306,308,308,
		310,310,313,313,315,315,317,317,319,319,321,321,323,323,325,325,327,327,
		330,330,332,332,334,334,336,336,338,338,340,340,342,342,344,344,346,346,
		348,348,350,350,352,352,354,354,356,356,358,358,360,360,362,362,364,364,
		366,366,368,368,370,370,372,372,374,374,376,377,379,379,381,381,385,386,
		388,388,390,391,393,395,398,401,403,404,406,408,412,413,415,416,418,418,
		420,420,422,423,425,425,428,428,430,431,433,435,437,437,439,440,444,444,
		452,452,455,455,458,458,461,461,463,463,465,465,467,467,469,469,471,471,
		473,473,475,475,478,478,480,480,482,482,484,484,486,486,488,488,490,490,
		492,492,494,494,497,497,500,500,502,504,506,506,508,508,510,510,512,512,
		514,514,516,516,518,518,520,520,522,522,524,524,526,526,528,528,530,530,
		532,532,534,534,536,536,538,538,540,540,542,542,544,544,546,546,548,548,
		550,550,552,552,554,554,556,556,558,558,560,560,562,562,570,571,573,574,
		577,577,579,582,584,584,586,586,588,588,590,590,880,880,882,882,886,886,
		902,902,904,906,908,908,910,911,913,929,931,939,975,975,978,980,984,984,
		986,986,988,988,990,990,992,992,994,994,996,996,998,998,1000,1000,1002,
		1002,1004,1004,1006,1006,1012,1012,1015,1015,1017,1018,1021,1071,1120,
		1120,1122,1122,1124,1124,1126,1126,1128,1128,1130,1130,1132,1132,1134,
		1134,1136,1136,1138,1138,1140,1140,1142,1142,1144,1144,1146,1146,1148,
		1148,1150,1150,1152,1152,1162,1162,1164,1164,1166,1166,1168,1168,1170,
		1170,1172,1172,1174,1174,1176,1176,1178,1178,1180,1180,1182,1182,1184,
		1184,1186,1186,1188,1188,1190,1190,1192,1192,1194,1194,1196,1196,1198,
		1198,1200,1200,1202,1202,1204,1204,1206,1206,1208,1208,1210,1210,1212,
		1212,1214,1214,1216,1217,1219,1219,1221,1221,1223,1223,1225,1225,1227,
		1227,1229,1229,1232,1232,1234,1234,1236,1236,1238,1238,1240,1240,1242,
		1242,1244,1244,1246,1246,1248,1248,1250,1250,1252,1252,1254,1254,1256,
		1256,1258,1258,1260,1260,1262,1262,1264,1264,1266,1266,1268,1268,1270,
		1270,1272,1272,1274,1274,1276,1276,1278,1278,1280,1280,1282,1282,1284,
		1284,1286,1286,1288,1288,1290,1290,1292,1292,1294,1294,1296,1296,1298,
		1298,1300,1300,1302,1302,1304,1304,1306,1306,1308,1308,1310,1310,1312,
		1312,1314,1314,1316,1316,1318,1318,1329,1366,4256,4293,4295,4295,4301,
		4301,7680,7680,7682,7682,7684,7684,7686,7686,7688,7688,7690,7690,7692,
		7692,7694,7694,7696,7696,7698,7698,7700,7700,7702,7702,7704,7704,7706,
		7706,7708,7708,7710,7710,7712,7712,7714,7714,7716,7716,7718,7718,7720,
		7720,7722,7722,7724,7724,7726,7726,7728,7728,7730,7730,7732,7732,7734,
		7734,7736,7736,7738,7738,7740,7740,7742,7742,7744,7744,7746,7746,7748,
		7748,7750,7750,7752,7752,7754,7754,7756,7756,7758,7758,7760,7760,7762,
		7762,7764,7764,7766,7766,7768,7768,7770,7770,7772,7772,7774,7774,7776,
		7776,7778,7778,7780,7780,7782,7782,7784,7784,7786,7786,7788,7788,7790,
		7790,7792,7792,7794,7794,7796,7796,7798,7798,7800,7800,7802,7802,7804,
		7804,7806,7806,7808,7808,7810,7810,7812,7812,7814,7814,7816,7816,7818,
		7818,7820,7820,7822,7822,7824,7824,7826,7826,7828,7828,7838,7838,7840,
		7840,7842,7842,7844,7844,7846,7846,7848,7848,7850,7850,7852,7852,7854,
		7854,7856,7856,7858,7858,7860,7860,7862,7862,7864,7864,7866,7866,7868,
		7868,7870,7870,7872,7872,7874,7874,7876,7876,7878,7878,7880,7880,7882,
		7882,7884,7884,7886,7886,7888,7888,7890,7890,7892,7892,7894,7894,7896,
		7896,7898,7898,7900,7900,7902,7902,7904,7904,7906,7906,7908,7908,7910,
		7910,7912,7912,7914,7914,7916,7916,7918,7918,7920,7920,7922,7922,7924,
		7924,7926,7926,7928,7928,7930,7930,7932,7932,7934,7934,7944,7951,7960,
		7965,7976,7983,7992,7999,8008,8013,8025,8025,8027,8027,8029,8029,8031,
		8031,8040,8047,8120,8123,8136,8139,8152,8155,8168,8172,8184,8187,8450,
		8450,8455,8455,8459,8461,8464,8466,8469,8469,8473,8477,8484,8484,8486,
		8486,8488,8488,8490,8493,8496,8499,8510,8511,8517,8517,8579,8579,11264,
		11310,11360,11360,11362,11364,11367,11367,11369,11369,11371,11371,11373,
		11376,11378,11378,11381,11381,11390,11392,11394,11394,11396,11396,11398,
		11398,11400,11400,11402,11402,11404,11404,11406,11406,11408,11408,11410,
		11410,11412,11412,11414,11414,11416,11416,11418,11418,11420,11420,11422,
		11422,11424,11424,11426,11426,11428,11428,11430,11430,11432,11432,11434,
		11434,11436,11436,11438,11438,11440,11440,11442,11442,11444,11444,11446,
		11446,11448,11448,11450,11450,11452,11452,11454,11454,11456,11456,11458,
		11458,11460,11460,11462,11462,11464,11464,11466,11466,11468,11468,11470,
		11470,11472,11472,11474,11474,11476,11476,11478,11478,11480,11480,11482,
		11482,11484,11484,11486,11486,11488,11488,11490,11490,11499,11499,11501,
		11501,11506,11506,42560,42560,42562,42562,42564,42564,42566,42566,42568,
		42568,42570,42570,42572,42572,42574,42574,42576,42576,42578,42578,42580,
		42580,42582,42582,42584,42584,42586,42586,42588,42588,42590,42590,42592,
		42592,42594,42594,42596,42596,42598,42598,42600,42600,42602,42602,42604,
		42604,42624,42624,42626,42626,42628,42628,42630,42630,42632,42632,42634,
		42634,42636,42636,42638,42638,42640,42640,42642,42642,42644,42644,42646,
		42646,42786,42786,42788,42788,42790,42790,42792,42792,42794,42794,42796,
		42796,42798,42798,42802,42802,42804,42804,42806,42806,42808,42808,42810,
		42810,42812,42812,42814,42814,42816,42816,42818,42818,42820,42820,42822,
		42822,42824,42824,42826,42826,42828,42828,42830,42830,42832,42832,42834,
		42834,42836,42836,42838,42838,42840,42840,42842,42842,42844,42844,42846,
		42846,42848,42848,42850,42850,42852,42852,42854,42854,42856,42856,42858,
		42858,42860,42860,42862,42862,42873,42873,42875,42875,42877,42878,42880,
		42880,42882,42882,42884,42884,42886,42886,42891,42891,42893,42893,42896,
		42896,42898,42898,42912,42912,42914,42914,42916,42916,42918,42918,42920,
		42920,42922,42922,65313,65338,35,0,48,57,1632,1641,1776,1785,1984,1993,
		2406,2415,2534,2543,2662,2671,2790,2799,2918,2927,3046,3055,3174,3183,
		3302,3311,3430,3439,3664,3673,3792,3801,3872,3881,4160,4169,4240,4249,
		6112,6121,6160,6169,6470,6479,6608,6617,6784,6793,6800,6809,6992,7001,
		7088,7097,7232,7241,7248,7257,42528,42537,43216,43225,43264,43273,43472,
		43481,43600,43609,44016,44025,65296,65305,7,0,5870,5872,8544,8578,8581,
		8584,12295,12295,12321,12329,12344,12346,42726,42735,28,0,1,1,0,0,0,0,
		3,1,0,0,0,0,5,1,0,0,0,0,7,1,0,0,0,0,9,1,0,0,0,0,11,1,0,0,0,0,13,1,0,0,
		0,1,15,1,0,0,0,3,17,1,0,0,0,5,19,1,0,0,0,7,21,1,0,0,0,9,23,1,0,0,0,11,
		25,1,0,0,0,13,27,1,0,0,0,15,16,7,0,0,0,16,2,1,0,0,0,17,18,7,1,0,0,18,4,
		1,0,0,0,19,20,7,2,0,0,20,6,1,0,0,0,21,22,7,3,0,0,22,8,1,0,0,0,23,24,7,
		4,0,0,24,10,1,0,0,0,25,26,7,5,0,0,26,12,1,0,0,0,27,28,7,6,0,0,28,14,1,
		0,0,0,1,0,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}