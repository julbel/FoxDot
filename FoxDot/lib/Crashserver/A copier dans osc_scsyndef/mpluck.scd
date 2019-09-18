(
SynthDef(\mpluck,
{|amp=1, sus=1, pan=0, freq=0, vib=0, fmod=0, rate=0, bus=0, blur=1, beat_dur=1, atk=0.01, decay=0.01, rel=0.01, peak=1, level=0.8, legato=1, filter=3, para1=0.5, dur=2|
var osc, osc_pluck, osc_moog,env;
sus = sus * blur;
freq = In.kr(bus, 1);
freq = [freq, freq+fmod];
amp=(amp + 1e-05);
freq=(freq + [0, LFNoise2.ar(50).range(-2, 2)]);
osc_pluck = Pluck.ar(PinkNoise.ar,1,0.2,freq.reciprocal,dur*legato,1-para1);
osc_moog = 	MoogFF.ar(osc_pluck, (freq*3),2);
osc = SelectX.ar(0.5,[LPF.ar(osc_pluck,2500),osc_moog]);
osc=((osc * XLine.kr(amp, (amp / 10000), (sus * 4), doneAction: 2)) * 1);
osc = Mix(osc) * 1;
osc = Pan2.ar(osc, pan);
ReplaceOut.ar(bus, osc)}).add;
)