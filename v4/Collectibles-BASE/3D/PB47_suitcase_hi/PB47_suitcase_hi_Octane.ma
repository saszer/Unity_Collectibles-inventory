requires maya "2017";
requires -nodeType "octaneDiffuseMaterial" -nodeType "octaneSpecularMaterial" -nodeType "octaneMixMaterial"
		 -nodeType "octaneMixTexture" -nodeType "octaneImageTexture" -nodeType "octaneFalloffTexture"
		 -nodeType "octaneUVProjection" -dataType "octaneMaterialData" -dataType "octaneTextureData"
		 -dataType "octaneEmissionData" -dataType "octaneMediumData" -dataType "octaneTransformData"
		 -dataType "octaneGeoData" -dataType "octaneProjectionData" -dataType "octaneEnvironmentData"
currentUnit -l centimeter -a degree -t film;
fileInfo "application" "maya";
fileInfo "product" "Maya 2017";
fileInfo "version" "2017";
createNode octaneDiffuseMaterial -n "octaneDiffuseMaterial1";
	setAttr ".vpar" -type "stringArray" 0  ;
	setAttr ".upar" -type "stringArray" 0  ;
	setAttr ".tm" -type "octaneTextureData" 

		"t"	17
		"f"	0	3095.76	3.02203e+032
		"i"	1282564418	1970239841	1161919604
		"b"	1
		"s"	""
		"v"	0;
	setAttr ".r" -type "octaneTextureData" 

		"t"	17
		"f"	1e-007	0	-1.51539e+031
		"i"	2046	0	0
		"b"	1
		"s"	""
		"v"	0;
	setAttr ".nm" -type "octaneTextureData" 

		"t"	0
		"f"	1.71789e+016	0	1.53985e+016
		"i"	0	1515901808	0
		"b"	0
		"s"	""
		"v"	0;
	setAttr ".d" -type "octaneDisplacementData" 

		"t"	0
		"f"	0	0	0
		"i"	0	0	0
		"b"	0
		"s"	""
		"v"	0;
	setAttr ".op" -type "octaneTextureData" 

		"t"	17
		"f"	1	0	1.31994e+016
		"i"	0	1513853744	0
		"b"	0
		"s"	""
		"v"	0;
	setAttr ".em" -type "octaneEmissionData" 

		"t"	0
		"f"	0	0	0
		"i"	0	0	0
		"b"	0
		"s"	""
		"v"	0;
	setAttr ".mm" -type "octaneMediumData" 

		"t"	0
		"f"	0	0	0
		"i"	0	0	0
		"b"	0
		"s"	""
		"v"	0;
createNode octaneMixMaterial -n "octaneMixMaterial1";
	setAttr ".vpar" -type "stringArray" 0  ;
	setAttr ".upar" -type "stringArray" 0  ;
	setAttr ".d" -type "octaneDisplacementData" 

		"t"	0
		"f"	0	0	-1.51539e+031
		"i"	2046	0	0
		"b"	1
		"s"	""
		"v"	0;
createNode octaneSpecularMaterial -n "octaneSpecularMaterial1";
	setAttr ".vpar" -type "stringArray" 0  ;
	setAttr ".upar" -type "stringArray" 0  ;
	setAttr ".tr" -type "octaneTextureData" 

		"t"	17
		"f"	0	8.90815e-039	8.90821e-039
		"i"	3145778	3604529	7536687
		"b"	1
		"s"	""
		"v"	0;
	setAttr ".i" 8;
	setAttr ".fw" -type "octaneTextureData" 

		"t"	17
		"f"	0	0	1.79672e-036
		"i"	0	0	0
		"b"	0
		"s"	""
		"v"	0;
	setAttr ".n" -type "octaneTextureData" 

		"t"	0
		"f"	0	0	-1.51539e+031
		"i"	2046	0	0
		"b"	1
		"s"	""
		"v"	0;
	setAttr ".dpl" -type "octaneDisplacementData" 

		"t"	0
		"f"	0	0	-1.51539e+031
		"i"	2046	0	0
		"b"	1
		"s"	""
		"v"	0;
	setAttr ".op" -type "octaneTextureData" 

		"t"	17
		"f"	1	0	-1.51539e+031
		"i"	2046	0	0
		"b"	1
		"s"	""
		"v"	0;
	setAttr ".mm" -type "octaneMediumData" 

		"t"	0
		"f"	0	0	-1.51539e+031
		"i"	2046	0	0
		"b"	1
		"s"	""
		"v"	0;
createNode octaneImageTexture -n "octaneMetallnessTxt";
	setAttr ".f" -type "string" "PB47_suitcase_hi_metallness.jpg";
	setAttr ".p" -type "octaneTextureData" 

		"t"	17
		"f"	1	5.88686e+022	1.77429e+028
		"i"	1467114852	1868852841	1851871351
		"b"	1
		"s"	""
		"v"	0;
	setAttr ".g" 1;
createNode octaneImageTexture -n "octaneRoughnessTxt";
	setAttr ".f" -type "string" "PB47_suitcase_hi_roughness.jpg";
	setAttr ".p" -type "octaneTextureData" 

		"t"	17
		"f"	1	5.88686e+022	1.77429e+028
		"i"	1467114852	1868852841	1851871351
		"b"	1
		"s"	""
		"v"	0;
	setAttr ".g" 1;
createNode octaneImageTexture -n "octaneImageTexture2";
	setAttr ".f" -type "string" "PB47_suitcase_hi_bump.png";
	setAttr ".p" -type "octaneTextureData" 

		"t"	17
		"f"	0.5	0	0
		"i"	0	0	0
		"b"	0
		"s"	""
		"v"	0;
	setAttr ".g" 1;
createNode octaneImageTexture -n "octaneAlbedoTxt";
	setAttr ".f" -type "string" "PB47_suitcase_hi_albedo.jpg";
	setAttr ".p" -type "octaneTextureData" 

		"t"	17
		"f"	1	5.88686e+022	1.77429e+028
		"i"	1467114852	1868852841	1851871351
		"b"	1
		"s"	""
		"v"	0;
createNode octaneUVProjection -n "octaneUVProjection1";
createNode octaneMixTexture -n "octaneMixTexture2";
	setAttr ".t2" -type "octaneTextureData" 

		"t"	17
		"f"	0	0	-1.51539e+031
		"i"	2046	0	0
		"b"	1
		"s"	""
		"v"	0;
createNode shadingEngine -n "octaneMixMaterial1SG";
	setAttr ".ihi" 0;
	setAttr -s 11 ".dsm";
	setAttr ".ro" yes;
createNode octaneMixTexture -n "octaneMixTexture4";
	setAttr ".t2" -type "octaneTextureData" 

		"t"	17
		"f"	1	0	-1.51539e+031
		"i"	2046	0	0
		"b"	1
		"s"	""
		"v"	0;
createNode octaneMixTexture -n "octaneMixTexture3";
	setAttr ".t2" -type "octaneTextureData" 

		"t"	17
		"f"	1	9.27555e-039	1.04694e-038
		"i"	6553705	3801189	6881388
		"b"	1
		"s"	""
		"v"	0;
createNode octaneFalloffTexture -n "octaneFalloffTexture1";
	setAttr ".n" 0.02158273383975029;
createNode materialInfo -n "materialInfo1";
createNode lightLinker -s -n "lightLinker1";
	setAttr -s 5 ".lnk";
	setAttr -s 5 ".slnk";
select -ne :time1;
	setAttr ".o" 1;
	setAttr ".unw" 1;
select -ne :hardwareRenderingGlobals;
	setAttr ".otfna" -type "stringArray" 22 "NURBS Curves" "NURBS Surfaces" "Polygons" "Subdiv Surface" "Particles" "Particle Instance" "Fluids" "Strokes" "Image Planes" "UI" "Lights" "Cameras" "Locators" "Joints" "IK Handles" "Deformers" "Motion Trails" "Components" "Hair Systems" "Follicles" "Misc. UI" "Ornaments"  ;
	setAttr ".otfva" -type "Int32Array" 22 0 1 1 1 1 1
		 1 1 1 0 0 0 0 0 0 0 0 0
		 0 0 0 0 ;
	setAttr ".fprt" yes;
select -ne :renderPartition;
	setAttr -s 5 ".st";
select -ne :renderGlobalsList1;
select -ne :defaultShaderList1;
	setAttr -s 7 ".s";
select -ne :postProcessList1;
	setAttr -s 2 ".p";
select -ne :defaultRenderUtilityList1;
select -ne :defaultRenderingList1;
select -ne :defaultTextureList1;
	setAttr -s 10 ".tx";
select -ne :initialShadingGroup;
	setAttr ".ro" yes;
select -ne :initialParticleSE;
	setAttr ".ro" yes;
select -ne :defaultRenderGlobals;
	setAttr ".ren" -type "string" "OctaneRender";
select -ne :defaultResolution;
	setAttr ".pa" 1;
select -ne :hardwareRenderGlobals;
	setAttr ".ctrs" 256;
	setAttr ".btrs" 512;
connectAttr "octaneAlbedoTxt.t" "octaneDiffuseMaterial1.df";
connectAttr "octaneImageTexture2.t" "octaneDiffuseMaterial1.bm";
connectAttr "octaneSpecularMaterial1.m" "octaneMixMaterial1.m1";
connectAttr "octaneDiffuseMaterial1.m" "octaneMixMaterial1.m2";
connectAttr "octaneMixTexture4.t" "octaneMixMaterial1.a";
connectAttr "octaneRoughnessTxt.t" "octaneSpecularMaterial1.rg";
connectAttr "octaneMixTexture3.t" "octaneSpecularMaterial1.rf";
connectAttr "octaneImageTexture2.t" "octaneSpecularMaterial1.b";
connectAttr "octaneUVProjection1.p" "octaneRoughnessTxt.pr";
connectAttr "octaneFalloffTexture1.t" "octaneMixTexture2.t1";
connectAttr "octaneRoughnessTxt.t" "octaneMixTexture2.a";
connectAttr "octaneMixMaterial1.oc" "octaneMixMaterial1SG.ss";
connectAttr "model1:RezervuarShape.iog" "octaneMixMaterial1SG.dsm" -na;
connectAttr "model1:KryshkaShape.iog" "octaneMixMaterial1SG.dsm" -na;
connectAttr "model1:RuchkyShape.iog" "octaneMixMaterial1SG.dsm" -na;
connectAttr "model1:PodstavkaShape.iog" "octaneMixMaterial1SG.dsm" -na;
connectAttr "model1:DekorShape.iog" "octaneMixMaterial1SG.dsm" -na;
connectAttr "model1:KranShape.iog" "octaneMixMaterial1SG.dsm" -na;
connectAttr "model1:VintilShape.iog" "octaneMixMaterial1SG.dsm" -na;
connectAttr "model1:BoltShape.iog" "octaneMixMaterial1SG.dsm" -na;
connectAttr "model1:RetopoGroup1Shape.iog" "octaneMixMaterial1SG.dsm" -na;
connectAttr "model1:Ruchky2Shape.iog" "octaneMixMaterial1SG.dsm" -na;
connectAttr "octaneFalloffTexture1.t" "octaneMixTexture4.t1";
connectAttr "octaneMetallnessTxt.t" "octaneMixTexture4.a";
connectAttr "octaneMixTexture2.t" "octaneMixTexture3.a";
connectAttr "octaneAlbedoTxt.t" "octaneMixTexture3.t1";
connectAttr "octaneMixMaterial1SG.msg" "materialInfo1.sg";
connectAttr "octaneMixMaterial1.msg" "materialInfo1.m";
relationship "link" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" "octaneMixMaterial1SG.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" "octaneMixMaterial1SG.message" ":defaultLightSet.message";
connectAttr "octaneMixMaterial1SG.pa" ":renderPartition.st" -na;
connectAttr "octaneMixMaterial1.msg" ":defaultShaderList1.s" -na;
connectAttr "octaneDiffuseMaterial1.msg" ":defaultShaderList1.s" -na;
connectAttr "octaneSpecularMaterial1.msg" ":defaultShaderList1.s" -na;
connectAttr "octaneFalloffTexture1.msg" ":defaultTextureList1.tx" -na;
connectAttr "octaneRoughnessTxt.msg" ":defaultTextureList1.tx" -na;
connectAttr "octaneUVProjection1.msg" ":defaultTextureList1.tx" -na;
connectAttr "octaneAlbedoTxt.msg" ":defaultTextureList1.tx" -na;
connectAttr "octaneMetallnessTxt.msg" ":defaultTextureList1.tx" -na;
connectAttr "octaneMixTexture2.msg" ":defaultTextureList1.tx" -na;
connectAttr "octaneMixTexture3.msg" ":defaultTextureList1.tx" -na;
connectAttr "octaneMixTexture4.msg" ":defaultTextureList1.tx" -na;
connectAttr "octaneImageTexture2.msg" ":defaultTextureList1.tx" -na;
// End of Octane.ma



file -import  -mergeNamespacesOnClash true -namespace "mymodel" "PB47_suitcase_hi.obj";

select -r "mymodel:*" ;
selectKey -clear ;

sets -e -forceElement octaneMixMaterial1SG;
doGroup 0 1 1;