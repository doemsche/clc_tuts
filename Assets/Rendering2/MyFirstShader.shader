﻿Shader "Custom/My First Shader" {
	SubShader{
		Pass {
			CGPROGRAM

			#pragma vertex MyVertexProgram
			#pragma fragment MyFragmentProgram
			#include "UnityCG.cginc"
			void MyVertexProgram(){

			}

			void MyFragmentProgram(){

			}

			ENDCG
		}
	}
}