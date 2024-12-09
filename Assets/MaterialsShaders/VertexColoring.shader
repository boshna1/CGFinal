Shader "Vertex Coloring Shader"
{
    SubShader
    {
        Pass
        {
            CGPROGRAM
        #pragma vertex vert
        #pragma fragment frag

        #include "Lighting.cginc"

        struct appdata
        {
            float4 vertex : POSITION;
        };
        struct v2f
        {
            float4 vertex : SV_POSITION;
            float4 color : COLOR;
        };

        v2f vert (appdata v)
        {
            v2f o;
            UNITY_INITIALIZE_OUTPUT(v2f,o)
            o.vertex = UnityObjectToClipPos(v.vertex);
            return o;
        }

        fixed4 frag (v2f i) : SV_Target
        {
            
            fixed4 col = i.color;
            col.r = i.vertex.x/_Time.y;
            col.g = i.vertex.x/_Time.y * 0.5;
            col.b = i.vertex.x/_Time.y * 0.25;
            return col;
        }
        ENDCG
        }
        
    }
 }