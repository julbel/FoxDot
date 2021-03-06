from ..Effects import *

# Fx LOOP
fx = FxList.new('fx1','fxout', {'fx1': 0}, order=1)
fx.doc("FX1 Bus")
fx.add("Out.ar(2, Mix.ar(osc*fx1))")
fx.save()

fx = FxList.new('fx2','fx2out', {'fx2': 0}, order=1)
fx.doc("FX2 Bus")
fx.add("Out.ar(3, Mix.ar(osc*fx2))")
fx.save()

# Legato slide
fx = FxList.new("leg", "leg", {"leg":0, "sus":1 }, order = 0)
fx.add("osc = osc * XLine.ar(Rand(0.5,1.5)*leg,1,0.05*sus)")
fx.save()

# Lpf slide
fx = FxList.new('spf','SLPF', {'spf': 0, 'spr': 1, 'spfslide':1, 'spfend':15000}, order=2)
fx.add_var("spfenv")
fx.add('spfenv = EnvGen.ar(Env.new([spf, spfend], [spfslide]))')
fx.add('osc = RLPF.ar(osc, spfenv, spr)')
fx.save()

# MoogLPF
fx = FxList.new('mpf','MoogFF', {'mpf': 0, 'mpr': 0}, order=2)
fx.doc("MoogFF filter")
fx.add('osc = MoogFF.ar(osc, mpf, mpr,0,1)')
fx.save()

# DFM1 LPF
fx = FxList.new('dfm','DFM1', {'dfm': 1000, 'dfmr': 0.1, 'dfmd': 1}, order=2)
fx.doc("DFM1 filter")
fx.add('osc = DFM1.ar(osc, dfm, dfmr, dfmd,0.0)')
fx.save()

if SC3_PLUGINS:
    #Dist mod
    fx = FxList.new('disto', 'disto_mod', {'disto': 0, 'smooth': 0.3, 'distomix': 1}, order=1)
    fx.add("osc = LinXFade2.ar(CrossoverDistortion.ar(osc, amp:0.5*disto, smooth:smooth),  osc, 1-distomix)")
    fx.save()

#New Chop, with wave select :
#chopwave = (0: Pulse, 1: Tri, 2: Saw, 3: Sin, 4: Parabolic )
# and chopi = oscillator phase
fx = FxList.new('chop', 'chop', {'chop': 0, 'sus': 1, 'chopmix': 1, 'chopwave': 0, 'chopi': 0}, order=2)
fx.add("osc = LinXFade2.ar(osc * SelectX.kr(chopwave, [LFPulse.kr(chop / sus, iphase:chopi, add: 0.01), LFTri.kr(chop / sus, iphase:chopi, add: 0.01), LFSaw.kr(chop / sus, iphase:chopi, add: 0.01), FSinOsc.kr(chop / sus, iphase:chopi, add: 0.01), LFPar.kr(chop / sus, iphase:chopi, add: 0.01)]), osc, 1-chopmix)")
fx.save()


fx = FxList.new('tremolo', 'tremolo', {'tremolo': 0, 'beat_dur': 1, 'tremolomix': 1}, order=2)
fx.add("osc = LinXFade2.ar(osc * SinOsc.ar( tremolo / beat_dur, mul:0.5, add:0.5), osc, 1-tremolomix)")
fx.save()

fx = FxList.new('echo', 'combDelay', {'echo': 0, 'echomix' : 1, 'beat_dur': 1, 'echotime': 1}, order=2)
fx.add('osc = LinXFade2.ar(osc + CombL.ar(osc, delaytime: echo * beat_dur, maxdelaytime: 2 * beat_dur, decaytime: echotime * beat_dur), osc, 1-echomix)')
fx.save()

fx = FxList.new('flanger', 'flanger', {'flanger': 0, 'fdecay': 0, 'flangermix':1}, order=2)
fx.add("osc = LinXFade2.ar(CombC.ar(osc, 0.01, SinOsc.ar(flanger, 0, (0.01 * 0.5) - 0.001, (0.01 * 0.5) + 0.001), fdecay, 1),  osc, 1-flangermix)")
fx.save()

fx = FxList.new("formant", "formantFilter", {"formant": 0, 'formantmix': 1}, order=2)
fx.add("formant = (formant % 8) + 1")
fx.add("osc = LinXFade2.ar(Formlet.ar(osc, formant * 200, ((formant % 5 + 1)) / 1000, (formant * 1.5) / 600).tanh, osc, 1-formantmix)")
fx.save()

fx = FxList.new("shape", "wavesShapeDistortion", {"shape":0, "shapemix":1}, order=2)
fx.add("osc = LinXFade2.ar((osc * (shape * 50)).fold2(1).distort / 5, osc, 1-shapemix)")
fx.save()

fx = FxList.new("drive", "overdriveDistortion", {"drive":0, "drivemix":1}, order=2)
fx.add("osc = LinXFade2.ar((osc * (drive * 50)).clip(0,0.2).fold2(2), osc, 1-drivemix)")
fx.save()

fx = FxList.new("tanh", "tanhDisto", {"tanh":0}, order=2)
fx.add("osc = osc + (osc*tanh).tanh.sqrt()")
fx.save()

#based on Derek Kwan chorus
fx = FxList.new("chorus", "chorus", {"chorus":0, "chorusmix":1,  "chorusrate":1, "chorusmax":0.25, "chorusmin": 0.025}, order=2)
fx.add_var("lfos")
fx.add_var("voices=8")
fx.add("lfos = Array.fill(8, {SinOsc.ar(chorusrate * rrand(0.95, 1.05), rrand(0.0, 1.0), (chorusmax * 0.5) - chorusmin,  (chorusmax * 0.5) + chorusmin)})")
fx.add("voices = DelayC.ar(osc, chorusmax,lfos)")
fx.add("voices = Mix.ar(voices)")
fx.add("osc = LinXFade2.ar(voices + osc, osc, 1-chorusmix)")
fx.save()

fx = FxList.new('octafuz', 'octafuz', {'octafuz': 0, 'octamix': 1}, order=2)
fx.add_var("dis")
fx.add_var("osc_base")
fx.add("osc_base = osc")
fx.add("dis = [1,1.01,2,2.02,4.5,6.01,7.501]")
fx.add("dis = dis ++ (dis*12)")
fx.add("osc = ((osc * dis*octafuz).sum.distort*4)")
fx.add("osc = (osc * 1/16)!2")
fx.add("osc = LinXFade2.ar(osc_base, osc, octamix)")
fx.save()

fx = FxList.new('tek', 'tek', {'tek': 0, 'tekr':4000, 'tekd':0.05}, order=2)
fx.add_var("osc_low")
fx.add_var("osc_med")
fx.add_var("osc_high")
fx.add_var("osc_base")
fx.add_var("lfo")
fx.add("lfo = SinOsc.ar(0.5, phase: 0, mul: 50, add: 100)")
fx.add("osc = In.ar(bus, 2)")
fx.add("osc_base = osc")
fx.add("osc_low = LPF.ar(osc, lfo) * 4")
fx.add("osc_med = BPF.ar(osc, lfo * 8)")
fx.add("osc_med = osc_med + Ringz.ar(CrossoverDistortion.ar(osc_med, 0.1, 0.1, 0.4),100, decaytime: 0.45, mul:0.1)")
fx.add("osc_med = LeakDC.ar(osc_med)")
fx.add("osc_high = HPF.ar(osc, 4000 + SinOsc.ar(8, mul: 800))")
fx.add("osc_high = Ringz.ar(osc_high, lfo * SinOsc.ar(1, mul: 1, add:1))")
fx.add("osc = osc_low + osc_med + osc_high")
fx.add("osc = DFM1.ar(osc, 200, 0.99, 0.2, 0) + osc")
fx.add("osc = InsideOut.ar(osc, tekd) + osc")
fx.add("osc = RHPF.ar(Gammatone.ar(osc, tekr), tekr, mul:2) + osc")
fx.add("osc = LinXFade2.ar(osc_base, osc, tek)")
fx.save()


### TIDAL FX ####
fx = FxList.new("krush", "dirt_krush", {"krush":0, "kutoff":15000}, order=2)
fx.add_var("signal")
fx.add_var("freq")
fx.add("freq = Select.kr(kutoff > 0, [DC.kr(4000), kutoff])")
fx.add("signal = (osc.squared + (krush * osc)) / (osc.squared + (osc.abs * (krush-1.0)) + 1.0)")
fx.add("signal = RLPF.ar(signal, clip(freq, 20, 10000), 1)")
fx.add("osc = SelectX.ar(krush * 2.0, [osc, signal])")
fx.save()

fx = FxList.new("drop", "waveloss", {"drop":0, "dropof": 100}, order=2)
fx.add("osc = WaveLoss.ar(osc, drop, outof: dropof, mode: 2)")
fx.save()

fx = FxList.new("squiz", "squiz", {"squiz":0}, order=2)
fx.add("osc = Squiz.ar(osc, squiz)")
fx.save()

fx = FxList.new("triode", "triode", {"triode":0}, order=2)
fx.add_var("sc")
fx.add("sc = triode * 10 + 1e-3")
fx.add("osc = (osc * (osc > 0)) + (tanh(osc * sc) / sc * (osc < 0))")
fx.add("osc = LeakDC.ar(osc)*1.2")
fx.save()

#### Need Tweak ##############
fx = FxList.new("octer", "octer", {"octer":0, "octersub": 0, "octersubsub": 0}, order=1)
fx.add_var("oct1")
fx.add_var("oct2")
fx.add_var("oct3")
fx.add_var("sub")
fx.add("oct1 = 2.0 * LeakDC.ar(abs(osc))")
fx.add("sub = LPF.ar(osc, 440)")
fx.add("oct2 = ToggleFF.ar(sub)")
fx.add("oct3 = ToggleFF.ar(oct2)")
fx.add("osc = SelectX.ar(octer, [osc, octer*oct1, DC.ar(0)])")
fx.add("osc = osc + (octersub * oct2 * sub) + (octersubsub * oct3 * sub)")
fx.save()

fx = FxList.new("feed", "feeddelay", {"feed":0.7, "feedfreq": 50}, order=2)
fx.add_var("out")
fx.add("out = osc + Fb({\
		arg feedback;\
		osc = CombN.ar(HPF.ar(feedback*feed, feedfreq) + osc, 0.5, 0.25).tanh;\
	},0.5,0.125)")
fx.save()


###########

Effect.server.setFx(FxList)

