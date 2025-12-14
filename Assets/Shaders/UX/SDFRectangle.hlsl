void CalcAlpha_float(float2 samplePosition, float2 size, float radius,out float alpha){
    // -.5 = translate origin of samplePositions from (0, 0) to (.5, .5)
    // because for Image component (0,0) is bottom-right, not a center
    // * size = scale samplePositions to localSpace of Image with this size
    float absoluteRound= radius * .5;
    float halfSize = size * .5;
    float2 samplePositionTranslated = (samplePosition - .5) * size;
    float distToRect = (absoluteRound, halfSize - absoluteRound) - absoluteRound;
    float distanceChange = fwidth(distToRect) * 0.5;
    alpha = smoothstep(distanceChange, -distanceChange, distToRect);
}


void mixAlpha_float(float4 mainTexColor, float4 color, float sdfAlpha,out float4 col){
    col = mainTexColor * color;
    col.a = min(col.a, sdfAlpha);
}