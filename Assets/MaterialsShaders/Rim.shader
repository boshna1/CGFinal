Shader "Rim Shader"
{
    Properties
    {
        _RimColor("Rim Color", Color) = (0,0.5,0.5,0)
        _RimPower("Rim Power", Range(0.5,5)) = 3
    }
    
    SubShader
    {
        Tags{"Queue" = "Transparent"}
        Pass
        {
            ZWrite On
            ColorMask 0
        }
        CGPROGRAM
        
        
        #pragma surface surf Lambert : fade surface
        struct Input
        {
            float3 viewDir;
        };

        float4 _RimColor;
        float _RimPower;
        void surf (Input IN, inout SurfaceOutput o)
        {
            half rim = 1.0 - saturate(dot (normalize(IN.viewDir), o.Normal));
            o.Emission = _RimColor.rgb * pow (rim,_RimPower);
            o.Alpha = _RimColor.a;
        }
        ENDCG
    }
Fallback "Diffuse"
        
}