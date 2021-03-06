﻿using System.Collections.Generic;
using PluginContracts;
using QuickType;
using System.Text;

namespace ReceptivitiAPI
{
    public partial class ReceptivitiAPI : Plugin
    {


        private static Dictionary<int, string> CreateHeader()
        {

            Dictionary<int, string> HeaderDat = new Dictionary<int, string>();

            HeaderDat.Add(0, "content_source");
            HeaderDat.Add(1, "liwc_scores.wc");
            HeaderDat.Add(2, "liwc_scores.sixLtr");
            HeaderDat.Add(3, "liwc_scores.clout");
            HeaderDat.Add(4, "liwc_scores.wps");
            HeaderDat.Add(5, "liwc_scores.analytic");
            HeaderDat.Add(6, "liwc_scores.tone");
            HeaderDat.Add(7, "liwc_scores.dic");
            HeaderDat.Add(8, "liwc_scores.authentic");
            HeaderDat.Add(9, "liwc_scores.categories.family");
            HeaderDat.Add(10, "liwc_scores.categories.feel");
            HeaderDat.Add(11, "liwc_scores.categories.money");
            HeaderDat.Add(12, "liwc_scores.categories.insight");
            HeaderDat.Add(13, "liwc_scores.categories.number");
            HeaderDat.Add(14, "liwc_scores.categories.Parenth");
            HeaderDat.Add(15, "liwc_scores.categories.cogproc");
            HeaderDat.Add(16, "liwc_scores.categories.OtherP");
            HeaderDat.Add(17, "liwc_scores.categories.female");
            HeaderDat.Add(18, "liwc_scores.categories.negate");
            HeaderDat.Add(19, "liwc_scores.categories.negemo");
            HeaderDat.Add(20, "liwc_scores.categories.differ");
            HeaderDat.Add(21, "liwc_scores.categories.death");
            HeaderDat.Add(22, "liwc_scores.categories.adverb");
            HeaderDat.Add(23, "liwc_scores.categories.informal");
            HeaderDat.Add(24, "liwc_scores.categories.ipron");
            HeaderDat.Add(25, "liwc_scores.categories.percept");
            HeaderDat.Add(26, "liwc_scores.categories.quant");
            HeaderDat.Add(27, "liwc_scores.categories.Exclam");
            HeaderDat.Add(28, "liwc_scores.categories.adj");
            HeaderDat.Add(29, "liwc_scores.categories.prep");
            HeaderDat.Add(30, "liwc_scores.categories.achieve");
            HeaderDat.Add(31, "liwc_scores.categories.function");
            HeaderDat.Add(32, "liwc_scores.categories.bio");
            HeaderDat.Add(33, "liwc_scores.categories.risk");
            HeaderDat.Add(34, "liwc_scores.categories.leisure");
            HeaderDat.Add(35, "liwc_scores.categories.Quote");
            HeaderDat.Add(36, "liwc_scores.categories.verb");
            HeaderDat.Add(37, "liwc_scores.categories.hear");
            HeaderDat.Add(38, "liwc_scores.categories.they");
            HeaderDat.Add(39, "liwc_scores.categories.affect");
            HeaderDat.Add(40, "liwc_scores.categories.you");
            HeaderDat.Add(41, "liwc_scores.categories.work");
            HeaderDat.Add(42, "liwc_scores.categories.Period");
            HeaderDat.Add(43, "liwc_scores.categories.friend");
            HeaderDat.Add(44, "liwc_scores.categories.focusfuture");
            HeaderDat.Add(45, "liwc_scores.categories.auxverb");
            HeaderDat.Add(46, "liwc_scores.categories.male");
            HeaderDat.Add(47, "liwc_scores.categories.shehe");
            HeaderDat.Add(48, "liwc_scores.categories.SemiC");
            HeaderDat.Add(49, "liwc_scores.categories.relig");
            HeaderDat.Add(50, "liwc_scores.categories.compare");
            HeaderDat.Add(51, "liwc_scores.categories.pronoun");
            HeaderDat.Add(52, "liwc_scores.categories.QMark");
            HeaderDat.Add(53, "liwc_scores.categories.certain");
            HeaderDat.Add(54, "liwc_scores.categories.assent");
            HeaderDat.Add(55, "liwc_scores.categories.we");
            HeaderDat.Add(56, "liwc_scores.categories.sad");
            HeaderDat.Add(57, "liwc_scores.categories.affiliation");
            HeaderDat.Add(58, "liwc_scores.categories.see");
            HeaderDat.Add(59, "liwc_scores.categories.anger");
            HeaderDat.Add(60, "liwc_scores.categories.home");
            HeaderDat.Add(61, "liwc_scores.categories.conj");
            HeaderDat.Add(62, "liwc_scores.categories.sexual");
            HeaderDat.Add(63, "liwc_scores.categories.ppron");
            HeaderDat.Add(64, "liwc_scores.categories.motion");
            HeaderDat.Add(65, "liwc_scores.categories.space");
            HeaderDat.Add(66, "liwc_scores.categories.filler");
            HeaderDat.Add(67, "liwc_scores.categories.anx");
            HeaderDat.Add(68, "liwc_scores.categories.focuspresent");
            HeaderDat.Add(69, "liwc_scores.categories.netspeak");
            HeaderDat.Add(70, "liwc_scores.categories.health");
            HeaderDat.Add(71, "liwc_scores.categories.discrep");
            HeaderDat.Add(72, "liwc_scores.categories.relativ");
            HeaderDat.Add(73, "liwc_scores.categories.Colon");
            HeaderDat.Add(74, "liwc_scores.categories.nonflu");
            HeaderDat.Add(75, "liwc_scores.categories.cause");
            HeaderDat.Add(76, "liwc_scores.categories.body");
            HeaderDat.Add(77, "liwc_scores.categories.tentat");
            HeaderDat.Add(78, "liwc_scores.categories.power");
            HeaderDat.Add(79, "liwc_scores.categories.interrog");
            HeaderDat.Add(80, "liwc_scores.categories.social");
            HeaderDat.Add(81, "liwc_scores.categories.drives");
            HeaderDat.Add(82, "liwc_scores.categories.focuspast");
            HeaderDat.Add(83, "liwc_scores.categories.article");
            HeaderDat.Add(84, "liwc_scores.categories.AllPunc");
            HeaderDat.Add(85, "liwc_scores.categories.Apostro");
            HeaderDat.Add(86, "liwc_scores.categories.i");
            HeaderDat.Add(87, "liwc_scores.categories.posemo");
            HeaderDat.Add(88, "liwc_scores.categories.ingest");
            HeaderDat.Add(89, "liwc_scores.categories.Dash");
            HeaderDat.Add(90, "liwc_scores.categories.swear");
            HeaderDat.Add(91, "liwc_scores.categories.Comma");
            HeaderDat.Add(92, "liwc_scores.categories.time");
            HeaderDat.Add(93, "liwc_scores.categories.reward");
            HeaderDat.Add(94, "organa_scores");
            HeaderDat.Add(95, "content_date");
            HeaderDat.Add(96, "content_tags");
            HeaderDat.Add(97, "user");
            HeaderDat.Add(98, "language");
            HeaderDat.Add(99, "communication_recommendation");
            HeaderDat.Add(100, "receptiviti_scores.percentiles.imaginative");
            HeaderDat.Add(101, "receptiviti_scores.percentiles.netspeak_focus");
            HeaderDat.Add(102, "receptiviti_scores.percentiles.persuasive");
            HeaderDat.Add(103, "receptiviti_scores.percentiles.liberal");
            HeaderDat.Add(104, "receptiviti_scores.percentiles.self_assured");
            HeaderDat.Add(105, "receptiviti_scores.percentiles.body_focus");
            HeaderDat.Add(106, "receptiviti_scores.percentiles.trusting");
            HeaderDat.Add(107, "receptiviti_scores.percentiles.organized");
            HeaderDat.Add(108, "receptiviti_scores.percentiles.type_a");
            HeaderDat.Add(109, "receptiviti_scores.percentiles.intellectual");
            HeaderDat.Add(110, "receptiviti_scores.percentiles.cheerful");
            HeaderDat.Add(111, "receptiviti_scores.percentiles.disciplined");
            HeaderDat.Add(112, "receptiviti_scores.percentiles.neuroticism");
            HeaderDat.Add(113, "receptiviti_scores.percentiles.cooperative");
            HeaderDat.Add(114, "receptiviti_scores.percentiles.social_skills");
            HeaderDat.Add(115, "receptiviti_scores.percentiles.openness");
            HeaderDat.Add(116, "receptiviti_scores.percentiles.aggressive");
            HeaderDat.Add(117, "receptiviti_scores.percentiles.adjustment");
            HeaderDat.Add(118, "receptiviti_scores.percentiles.religion_oriented");
            HeaderDat.Add(119, "receptiviti_scores.percentiles.empathetic");
            HeaderDat.Add(120, "receptiviti_scores.percentiles.food_focus");
            HeaderDat.Add(121, "receptiviti_scores.percentiles.generous");
            HeaderDat.Add(122, "receptiviti_scores.percentiles.sexual_focus");
            HeaderDat.Add(123, "receptiviti_scores.percentiles.thinking_style");
            HeaderDat.Add(124, "receptiviti_scores.percentiles.friend_focus");
            HeaderDat.Add(125, "receptiviti_scores.percentiles.extraversion");
            HeaderDat.Add(126, "receptiviti_scores.percentiles.agreeableness");
            HeaderDat.Add(127, "receptiviti_scores.percentiles.depression");
            HeaderDat.Add(128, "receptiviti_scores.percentiles.ambitious");
            HeaderDat.Add(129, "receptiviti_scores.percentiles.friendly");
            HeaderDat.Add(130, "receptiviti_scores.percentiles.money_oriented");
            HeaderDat.Add(131, "receptiviti_scores.percentiles.independent");
            HeaderDat.Add(132, "receptiviti_scores.percentiles.melancholy");
            HeaderDat.Add(133, "receptiviti_scores.percentiles.workhorse");
            HeaderDat.Add(134, "receptiviti_scores.percentiles.reward_bias");
            HeaderDat.Add(135, "receptiviti_scores.percentiles.energetic");
            HeaderDat.Add(136, "receptiviti_scores.percentiles.happiness");
            HeaderDat.Add(137, "receptiviti_scores.percentiles.self_conscious");
            HeaderDat.Add(138, "receptiviti_scores.percentiles.assertive");
            HeaderDat.Add(139, "receptiviti_scores.percentiles.insecure");
            HeaderDat.Add(140, "receptiviti_scores.percentiles.leisure_oriented");
            HeaderDat.Add(141, "receptiviti_scores.percentiles.impulsive");
            HeaderDat.Add(142, "receptiviti_scores.percentiles.cautious");
            HeaderDat.Add(143, "receptiviti_scores.percentiles.conscientiousness");
            HeaderDat.Add(144, "receptiviti_scores.percentiles.active");
            HeaderDat.Add(145, "receptiviti_scores.percentiles.power_driven");
            HeaderDat.Add(146, "receptiviti_scores.percentiles.dutiful");
            HeaderDat.Add(147, "receptiviti_scores.percentiles.genuine");
            HeaderDat.Add(148, "receptiviti_scores.percentiles.adventurous");
            HeaderDat.Add(149, "receptiviti_scores.percentiles.sociable");
            HeaderDat.Add(150, "receptiviti_scores.percentiles.family_oriented");
            HeaderDat.Add(151, "receptiviti_scores.percentiles.cold");
            HeaderDat.Add(152, "receptiviti_scores.percentiles.emotionally_aware");
            HeaderDat.Add(153, "receptiviti_scores.percentiles.humble");
            HeaderDat.Add(154, "receptiviti_scores.percentiles.anxious");
            HeaderDat.Add(155, "receptiviti_scores.percentiles.artistic");
            HeaderDat.Add(156, "receptiviti_scores.percentiles.stressed");
            HeaderDat.Add(157, "receptiviti_scores.percentiles.health_oriented");
            HeaderDat.Add(158, "receptiviti_scores.percentiles.work_oriented");
            HeaderDat.Add(159, "receptiviti_scores.raw_scores.imaginative");
            HeaderDat.Add(160, "receptiviti_scores.raw_scores.netspeak_focus");
            HeaderDat.Add(161, "receptiviti_scores.raw_scores.persuasive");
            HeaderDat.Add(162, "receptiviti_scores.raw_scores.liberal");
            HeaderDat.Add(163, "receptiviti_scores.raw_scores.self_assured");
            HeaderDat.Add(164, "receptiviti_scores.raw_scores.body_focus");
            HeaderDat.Add(165, "receptiviti_scores.raw_scores.trusting");
            HeaderDat.Add(166, "receptiviti_scores.raw_scores.organized");
            HeaderDat.Add(167, "receptiviti_scores.raw_scores.type_a");
            HeaderDat.Add(168, "receptiviti_scores.raw_scores.intellectual");
            HeaderDat.Add(169, "receptiviti_scores.raw_scores.cheerful");
            HeaderDat.Add(170, "receptiviti_scores.raw_scores.disciplined");
            HeaderDat.Add(171, "receptiviti_scores.raw_scores.neuroticism");
            HeaderDat.Add(172, "receptiviti_scores.raw_scores.cooperative");
            HeaderDat.Add(173, "receptiviti_scores.raw_scores.social_skills");
            HeaderDat.Add(174, "receptiviti_scores.raw_scores.openness");
            HeaderDat.Add(175, "receptiviti_scores.raw_scores.aggressive");
            HeaderDat.Add(176, "receptiviti_scores.raw_scores.adjustment");
            HeaderDat.Add(177, "receptiviti_scores.raw_scores.religion_oriented");
            HeaderDat.Add(178, "receptiviti_scores.raw_scores.empathetic");
            HeaderDat.Add(179, "receptiviti_scores.raw_scores.food_focus");
            HeaderDat.Add(180, "receptiviti_scores.raw_scores.generous");
            HeaderDat.Add(181, "receptiviti_scores.raw_scores.sexual_focus");
            HeaderDat.Add(182, "receptiviti_scores.raw_scores.thinking_style");
            HeaderDat.Add(183, "receptiviti_scores.raw_scores.friend_focus");
            HeaderDat.Add(184, "receptiviti_scores.raw_scores.extraversion");
            HeaderDat.Add(185, "receptiviti_scores.raw_scores.agreeableness");
            HeaderDat.Add(186, "receptiviti_scores.raw_scores.depression");
            HeaderDat.Add(187, "receptiviti_scores.raw_scores.ambitious");
            HeaderDat.Add(188, "receptiviti_scores.raw_scores.friendly");
            HeaderDat.Add(189, "receptiviti_scores.raw_scores.money_oriented");
            HeaderDat.Add(190, "receptiviti_scores.raw_scores.independent");
            HeaderDat.Add(191, "receptiviti_scores.raw_scores.melancholy");
            HeaderDat.Add(192, "receptiviti_scores.raw_scores.workhorse");
            HeaderDat.Add(193, "receptiviti_scores.raw_scores.reward_bias");
            HeaderDat.Add(194, "receptiviti_scores.raw_scores.energetic");
            HeaderDat.Add(195, "receptiviti_scores.raw_scores.happiness");
            HeaderDat.Add(196, "receptiviti_scores.raw_scores.self_conscious");
            HeaderDat.Add(197, "receptiviti_scores.raw_scores.assertive");
            HeaderDat.Add(198, "receptiviti_scores.raw_scores.insecure");
            HeaderDat.Add(199, "receptiviti_scores.raw_scores.leisure_oriented");
            HeaderDat.Add(200, "receptiviti_scores.raw_scores.impulsive");
            HeaderDat.Add(201, "receptiviti_scores.raw_scores.cautious");
            HeaderDat.Add(202, "receptiviti_scores.raw_scores.conscientiousness");
            HeaderDat.Add(203, "receptiviti_scores.raw_scores.active");
            HeaderDat.Add(204, "receptiviti_scores.raw_scores.power_driven");
            HeaderDat.Add(205, "receptiviti_scores.raw_scores.dutiful");
            HeaderDat.Add(206, "receptiviti_scores.raw_scores.genuine");
            HeaderDat.Add(207, "receptiviti_scores.raw_scores.adventurous");
            HeaderDat.Add(208, "receptiviti_scores.raw_scores.sociable");
            HeaderDat.Add(209, "receptiviti_scores.raw_scores.family_oriented");
            HeaderDat.Add(210, "receptiviti_scores.raw_scores.cold");
            HeaderDat.Add(211, "receptiviti_scores.raw_scores.emotionally_aware");
            HeaderDat.Add(212, "receptiviti_scores.raw_scores.humble");
            HeaderDat.Add(213, "receptiviti_scores.raw_scores.anxious");
            HeaderDat.Add(214, "receptiviti_scores.raw_scores.artistic");
            HeaderDat.Add(215, "receptiviti_scores.raw_scores.stressed");
            HeaderDat.Add(216, "receptiviti_scores.raw_scores.health_oriented");
            HeaderDat.Add(217, "receptiviti_scores.raw_scores.work_oriented");
            HeaderDat.Add(218, "receptiviti_scores.warnings");
            HeaderDat.Add(219, "personality_snapshot.0.description");
            HeaderDat.Add(220, "personality_snapshot.0.summary");
            HeaderDat.Add(221, "personality_snapshot.1.description");
            HeaderDat.Add(222, "personality_snapshot.1.summary");
            HeaderDat.Add(223, "personality_snapshot.2.description");
            HeaderDat.Add(224, "personality_snapshot.2.summary");
            HeaderDat.Add(225, "emotional_analysis.facets.anger");
            HeaderDat.Add(226, "emotional_analysis.facets.fear");
            HeaderDat.Add(227, "emotional_analysis.facets.sad");
            HeaderDat.Add(228, "emotional_analysis.emotional_tone.rating");
            HeaderDat.Add(229, "emotional_analysis.emotional_tone.score");
            HeaderDat.Add(230, "_links");

            return HeaderDat;


        }


        private string[] FlattenOutput(ReceptivitiOutput dat)
        {

            string[] output = new string[231];

            output[0] = dat.ContentSource.ToString();
            output[1] = dat.LiwcScores.Wc.ToString();
            output[2] = dat.LiwcScores.SixLtr.ToString();
            output[3] = dat.LiwcScores.Clout.ToString();
            output[4] = dat.LiwcScores.Wps.ToString();
            output[5] = dat.LiwcScores.Analytic.ToString();
            output[6] = dat.LiwcScores.Tone.ToString();
            output[7] = dat.LiwcScores.Dic.ToString();
            output[8] = dat.LiwcScores.Authentic.ToString();
            output[9] = dat.LiwcScores.Categories["family"].ToString();
            output[10] = dat.LiwcScores.Categories["feel"].ToString();
            output[11] = dat.LiwcScores.Categories["money"].ToString();
            output[12] = dat.LiwcScores.Categories["insight"].ToString();
            output[13] = dat.LiwcScores.Categories["number"].ToString();
            output[14] = dat.LiwcScores.Categories["Parenth"].ToString();
            output[15] = dat.LiwcScores.Categories["cogproc"].ToString();
            output[16] = dat.LiwcScores.Categories["OtherP"].ToString();
            output[17] = dat.LiwcScores.Categories["female"].ToString();
            output[18] = dat.LiwcScores.Categories["negate"].ToString();
            output[19] = dat.LiwcScores.Categories["negemo"].ToString();
            output[20] = dat.LiwcScores.Categories["differ"].ToString();
            output[21] = dat.LiwcScores.Categories["death"].ToString();
            output[22] = dat.LiwcScores.Categories["adverb"].ToString();
            output[23] = dat.LiwcScores.Categories["informal"].ToString();
            output[24] = dat.LiwcScores.Categories["ipron"].ToString();
            output[25] = dat.LiwcScores.Categories["percept"].ToString();
            output[26] = dat.LiwcScores.Categories["quant"].ToString();
            output[27] = dat.LiwcScores.Categories["Exclam"].ToString();
            output[28] = dat.LiwcScores.Categories["adj"].ToString();
            output[29] = dat.LiwcScores.Categories["prep"].ToString();
            output[30] = dat.LiwcScores.Categories["achieve"].ToString();
            output[31] = dat.LiwcScores.Categories["function"].ToString();
            output[32] = dat.LiwcScores.Categories["bio"].ToString();
            output[33] = dat.LiwcScores.Categories["risk"].ToString();
            output[34] = dat.LiwcScores.Categories["leisure"].ToString();
            output[35] = dat.LiwcScores.Categories["Quote"].ToString();
            output[36] = dat.LiwcScores.Categories["verb"].ToString();
            output[37] = dat.LiwcScores.Categories["hear"].ToString();
            output[38] = dat.LiwcScores.Categories["they"].ToString();
            output[39] = dat.LiwcScores.Categories["affect"].ToString();
            output[40] = dat.LiwcScores.Categories["you"].ToString();
            output[41] = dat.LiwcScores.Categories["work"].ToString();
            output[42] = dat.LiwcScores.Categories["Period"].ToString();
            output[43] = dat.LiwcScores.Categories["friend"].ToString();
            output[44] = dat.LiwcScores.Categories["focusfuture"].ToString();
            output[45] = dat.LiwcScores.Categories["auxverb"].ToString();
            output[46] = dat.LiwcScores.Categories["male"].ToString();
            output[47] = dat.LiwcScores.Categories["shehe"].ToString();
            output[48] = dat.LiwcScores.Categories["SemiC"].ToString();
            output[49] = dat.LiwcScores.Categories["relig"].ToString();
            output[50] = dat.LiwcScores.Categories["compare"].ToString();
            output[51] = dat.LiwcScores.Categories["pronoun"].ToString();
            output[52] = dat.LiwcScores.Categories["QMark"].ToString();
            output[53] = dat.LiwcScores.Categories["certain"].ToString();
            output[54] = dat.LiwcScores.Categories["assent"].ToString();
            output[55] = dat.LiwcScores.Categories["we"].ToString();
            output[56] = dat.LiwcScores.Categories["sad"].ToString();
            output[57] = dat.LiwcScores.Categories["affiliation"].ToString();
            output[58] = dat.LiwcScores.Categories["see"].ToString();
            output[59] = dat.LiwcScores.Categories["anger"].ToString();
            output[60] = dat.LiwcScores.Categories["home"].ToString();
            output[61] = dat.LiwcScores.Categories["conj"].ToString();
            output[62] = dat.LiwcScores.Categories["sexual"].ToString();
            output[63] = dat.LiwcScores.Categories["ppron"].ToString();
            output[64] = dat.LiwcScores.Categories["motion"].ToString();
            output[65] = dat.LiwcScores.Categories["space"].ToString();
            output[66] = dat.LiwcScores.Categories["filler"].ToString();
            output[67] = dat.LiwcScores.Categories["anx"].ToString();
            output[68] = dat.LiwcScores.Categories["focuspresent"].ToString();
            output[69] = dat.LiwcScores.Categories["netspeak"].ToString();
            output[70] = dat.LiwcScores.Categories["health"].ToString();
            output[71] = dat.LiwcScores.Categories["discrep"].ToString();
            output[72] = dat.LiwcScores.Categories["relativ"].ToString();
            output[73] = dat.LiwcScores.Categories["Colon"].ToString();
            output[74] = dat.LiwcScores.Categories["nonflu"].ToString();
            output[75] = dat.LiwcScores.Categories["cause"].ToString();
            output[76] = dat.LiwcScores.Categories["body"].ToString();
            output[77] = dat.LiwcScores.Categories["tentat"].ToString();
            output[78] = dat.LiwcScores.Categories["power"].ToString();
            output[79] = dat.LiwcScores.Categories["interrog"].ToString();
            output[80] = dat.LiwcScores.Categories["social"].ToString();
            output[81] = dat.LiwcScores.Categories["drives"].ToString();
            output[82] = dat.LiwcScores.Categories["focuspast"].ToString();
            output[83] = dat.LiwcScores.Categories["article"].ToString();
            output[84] = dat.LiwcScores.Categories["AllPunc"].ToString();
            output[85] = dat.LiwcScores.Categories["Apostro"].ToString();
            output[86] = dat.LiwcScores.Categories["i"].ToString();
            output[87] = dat.LiwcScores.Categories["posemo"].ToString();
            output[88] = dat.LiwcScores.Categories["ingest"].ToString();
            output[89] = dat.LiwcScores.Categories["Dash"].ToString();
            output[90] = dat.LiwcScores.Categories["swear"].ToString();
            output[91] = dat.LiwcScores.Categories["Comma"].ToString();
            output[92] = dat.LiwcScores.Categories["time"].ToString();
            output[93] = dat.LiwcScores.Categories["reward"].ToString();
            //output[94] = dat.OrganaScores.ToString();
            output[95] = dat.ContentDate.ToString();
            //output[96] = dat.ContentTags.ToString();
            output[97] = dat.User;
            output[98] = dat.Language;
            output[99] = dat.CommunicationRecommendation;
            output[100] = dat.ReceptivitiScores.Percentiles["imaginative"].ToString();
            output[101] = dat.ReceptivitiScores.Percentiles["netspeak_focus"].ToString();
            output[102] = dat.ReceptivitiScores.Percentiles["persuasive"].ToString();
            output[103] = dat.ReceptivitiScores.Percentiles["liberal"].ToString();
            output[104] = dat.ReceptivitiScores.Percentiles["self_assured"].ToString();
            output[105] = dat.ReceptivitiScores.Percentiles["body_focus"].ToString();
            output[106] = dat.ReceptivitiScores.Percentiles["trusting"].ToString();
            output[107] = dat.ReceptivitiScores.Percentiles["organized"].ToString();
            output[108] = dat.ReceptivitiScores.Percentiles["type_a"].ToString();
            output[109] = dat.ReceptivitiScores.Percentiles["intellectual"].ToString();
            output[110] = dat.ReceptivitiScores.Percentiles["cheerful"].ToString();
            output[111] = dat.ReceptivitiScores.Percentiles["disciplined"].ToString();
            output[112] = dat.ReceptivitiScores.Percentiles["neuroticism"].ToString();
            output[113] = dat.ReceptivitiScores.Percentiles["cooperative"].ToString();
            output[114] = dat.ReceptivitiScores.Percentiles["social_skills"].ToString();
            output[115] = dat.ReceptivitiScores.Percentiles["openness"].ToString();
            output[116] = dat.ReceptivitiScores.Percentiles["aggressive"].ToString();
            output[117] = dat.ReceptivitiScores.Percentiles["adjustment"].ToString();
            output[118] = dat.ReceptivitiScores.Percentiles["religion_oriented"].ToString();
            output[119] = dat.ReceptivitiScores.Percentiles["empathetic"].ToString();
            output[120] = dat.ReceptivitiScores.Percentiles["food_focus"].ToString();
            output[121] = dat.ReceptivitiScores.Percentiles["generous"].ToString();
            output[122] = dat.ReceptivitiScores.Percentiles["sexual_focus"].ToString();
            output[123] = dat.ReceptivitiScores.Percentiles["thinking_style"].ToString();
            output[124] = dat.ReceptivitiScores.Percentiles["friend_focus"].ToString();
            output[125] = dat.ReceptivitiScores.Percentiles["extraversion"].ToString();
            output[126] = dat.ReceptivitiScores.Percentiles["agreeableness"].ToString();
            output[127] = dat.ReceptivitiScores.Percentiles["depression"].ToString();
            output[128] = dat.ReceptivitiScores.Percentiles["ambitious"].ToString();
            output[129] = dat.ReceptivitiScores.Percentiles["friendly"].ToString();
            output[130] = dat.ReceptivitiScores.Percentiles["money_oriented"].ToString();
            output[131] = dat.ReceptivitiScores.Percentiles["independent"].ToString();
            output[132] = dat.ReceptivitiScores.Percentiles["melancholy"].ToString();
            output[133] = dat.ReceptivitiScores.Percentiles["workhorse"].ToString();
            output[134] = dat.ReceptivitiScores.Percentiles["reward_bias"].ToString();
            output[135] = dat.ReceptivitiScores.Percentiles["energetic"].ToString();
            output[136] = dat.ReceptivitiScores.Percentiles["happiness"].ToString();
            output[137] = dat.ReceptivitiScores.Percentiles["self_conscious"].ToString();
            output[138] = dat.ReceptivitiScores.Percentiles["assertive"].ToString();
            output[139] = dat.ReceptivitiScores.Percentiles["insecure"].ToString();
            output[140] = dat.ReceptivitiScores.Percentiles["leisure_oriented"].ToString();
            output[141] = dat.ReceptivitiScores.Percentiles["impulsive"].ToString();
            output[142] = dat.ReceptivitiScores.Percentiles["cautious"].ToString();
            output[143] = dat.ReceptivitiScores.Percentiles["conscientiousness"].ToString();
            output[144] = dat.ReceptivitiScores.Percentiles["active"].ToString();
            output[145] = dat.ReceptivitiScores.Percentiles["power_driven"].ToString();
            output[146] = dat.ReceptivitiScores.Percentiles["dutiful"].ToString();
            output[147] = dat.ReceptivitiScores.Percentiles["genuine"].ToString();
            output[148] = dat.ReceptivitiScores.Percentiles["adventurous"].ToString();
            output[149] = dat.ReceptivitiScores.Percentiles["sociable"].ToString();
            output[150] = dat.ReceptivitiScores.Percentiles["family_oriented"].ToString();
            output[151] = dat.ReceptivitiScores.Percentiles["cold"].ToString();
            output[152] = dat.ReceptivitiScores.Percentiles["emotionally_aware"].ToString();
            output[153] = dat.ReceptivitiScores.Percentiles["humble"].ToString();
            output[154] = dat.ReceptivitiScores.Percentiles["anxious"].ToString();
            output[155] = dat.ReceptivitiScores.Percentiles["artistic"].ToString();
            output[156] = dat.ReceptivitiScores.Percentiles["stressed"].ToString();
            output[157] = dat.ReceptivitiScores.Percentiles["health_oriented"].ToString();
            output[158] = dat.ReceptivitiScores.Percentiles["work_oriented"].ToString();
            output[159] = dat.ReceptivitiScores.RawScores["imaginative"].ToString();
            output[160] = dat.ReceptivitiScores.RawScores["netspeak_focus"].ToString();
            output[161] = dat.ReceptivitiScores.RawScores["persuasive"].ToString();
            output[162] = dat.ReceptivitiScores.RawScores["liberal"].ToString();
            output[163] = dat.ReceptivitiScores.RawScores["self_assured"].ToString();
            output[164] = dat.ReceptivitiScores.RawScores["body_focus"].ToString();
            output[165] = dat.ReceptivitiScores.RawScores["trusting"].ToString();
            output[166] = dat.ReceptivitiScores.RawScores["organized"].ToString();
            output[167] = dat.ReceptivitiScores.RawScores["type_a"].ToString();
            output[168] = dat.ReceptivitiScores.RawScores["intellectual"].ToString();
            output[169] = dat.ReceptivitiScores.RawScores["cheerful"].ToString();
            output[170] = dat.ReceptivitiScores.RawScores["disciplined"].ToString();
            output[171] = dat.ReceptivitiScores.RawScores["neuroticism"].ToString();
            output[172] = dat.ReceptivitiScores.RawScores["cooperative"].ToString();
            output[173] = dat.ReceptivitiScores.RawScores["social_skills"].ToString();
            output[174] = dat.ReceptivitiScores.RawScores["openness"].ToString();
            output[175] = dat.ReceptivitiScores.RawScores["aggressive"].ToString();
            output[176] = dat.ReceptivitiScores.RawScores["adjustment"].ToString();
            output[177] = dat.ReceptivitiScores.RawScores["religion_oriented"].ToString();
            output[178] = dat.ReceptivitiScores.RawScores["empathetic"].ToString();
            output[179] = dat.ReceptivitiScores.RawScores["food_focus"].ToString();
            output[180] = dat.ReceptivitiScores.RawScores["generous"].ToString();
            output[181] = dat.ReceptivitiScores.RawScores["sexual_focus"].ToString();
            output[182] = dat.ReceptivitiScores.RawScores["thinking_style"].ToString();
            output[183] = dat.ReceptivitiScores.RawScores["friend_focus"].ToString();
            output[184] = dat.ReceptivitiScores.RawScores["extraversion"].ToString();
            output[185] = dat.ReceptivitiScores.RawScores["agreeableness"].ToString();
            output[186] = dat.ReceptivitiScores.RawScores["depression"].ToString();
            output[187] = dat.ReceptivitiScores.RawScores["ambitious"].ToString();
            output[188] = dat.ReceptivitiScores.RawScores["friendly"].ToString();
            output[189] = dat.ReceptivitiScores.RawScores["money_oriented"].ToString();
            output[190] = dat.ReceptivitiScores.RawScores["independent"].ToString();
            output[191] = dat.ReceptivitiScores.RawScores["melancholy"].ToString();
            output[192] = dat.ReceptivitiScores.RawScores["workhorse"].ToString();
            output[193] = dat.ReceptivitiScores.RawScores["reward_bias"].ToString();
            output[194] = dat.ReceptivitiScores.RawScores["energetic"].ToString();
            output[195] = dat.ReceptivitiScores.RawScores["happiness"].ToString();
            output[196] = dat.ReceptivitiScores.RawScores["self_conscious"].ToString();
            output[197] = dat.ReceptivitiScores.RawScores["assertive"].ToString();
            output[198] = dat.ReceptivitiScores.RawScores["insecure"].ToString();
            output[199] = dat.ReceptivitiScores.RawScores["leisure_oriented"].ToString();
            output[200] = dat.ReceptivitiScores.RawScores["impulsive"].ToString();
            output[201] = dat.ReceptivitiScores.RawScores["cautious"].ToString();
            output[202] = dat.ReceptivitiScores.RawScores["conscientiousness"].ToString();
            output[203] = dat.ReceptivitiScores.RawScores["active"].ToString();
            output[204] = dat.ReceptivitiScores.RawScores["power_driven"].ToString();
            output[205] = dat.ReceptivitiScores.RawScores["dutiful"].ToString();
            output[206] = dat.ReceptivitiScores.RawScores["genuine"].ToString();
            output[207] = dat.ReceptivitiScores.RawScores["adventurous"].ToString();
            output[208] = dat.ReceptivitiScores.RawScores["sociable"].ToString();
            output[209] = dat.ReceptivitiScores.RawScores["family_oriented"].ToString();
            output[210] = dat.ReceptivitiScores.RawScores["cold"].ToString();
            output[211] = dat.ReceptivitiScores.RawScores["emotionally_aware"].ToString();
            output[212] = dat.ReceptivitiScores.RawScores["humble"].ToString();
            output[213] = dat.ReceptivitiScores.RawScores["anxious"].ToString();
            output[214] = dat.ReceptivitiScores.RawScores["artistic"].ToString();
            output[215] = dat.ReceptivitiScores.RawScores["stressed"].ToString();
            output[216] = dat.ReceptivitiScores.RawScores["health_oriented"].ToString();
            output[217] = dat.ReceptivitiScores.RawScores["work_oriented"].ToString();

            StringBuilder warnings = new StringBuilder();
            foreach (string key in dat.ReceptivitiScores.Warnings.Keys)
            {
                for (int i = 0; i < dat.ReceptivitiScores.Warnings[key].Length; i++) warnings.Append(key + ": " + dat.ReceptivitiScores.Warnings[key][i] + " ");
            }

            output[218] = warnings.ToString();
            output[219] = dat.PersonalitySnapshot[0].Description;
            output[220] = dat.PersonalitySnapshot[0].Summary;
            output[221] = dat.PersonalitySnapshot[1].Description;
            output[222] = dat.PersonalitySnapshot[1].Summary;
            output[223] = dat.PersonalitySnapshot[2].Description;
            output[224] = dat.PersonalitySnapshot[2].Summary;
            output[225] = dat.EmotionalAnalysis.Facets.Anger.ToString();
            output[226] = dat.EmotionalAnalysis.Facets.Fear.ToString();
            output[227] = dat.EmotionalAnalysis.Facets.Sad.ToString();
            output[228] = dat.EmotionalAnalysis.EmotionalTone.Rating;
            output[229] = dat.EmotionalAnalysis.EmotionalTone.Score.ToString();
            //output[230] = dat.Links.ToString();



            return output;


        }



    }
}
