/*! For license information please see bundle.js.LICENSE.txt */
var pcf_tools_652ac3f36e1e4bca82eb3c1dc44e6fad;(()=>{"use strict";var t={d:(e,o)=>{for(var r in o)t.o(o,r)&&!t.o(e,r)&&Object.defineProperty(e,r,{enumerable:!0,get:o[r]})},o:(t,e)=>Object.prototype.hasOwnProperty.call(t,e),r:t=>{"undefined"!=typeof Symbol&&Symbol.toStringTag&&Object.defineProperty(t,Symbol.toStringTag,{value:"Module"}),Object.defineProperty(t,"__esModule",{value:!0})}},e={};t.r(e),t.d(e,{Icon:()=>f});const o=React,r=FluentUIReactv8290;var n=void 0;try{n=window}catch(t){}function i(t){if(void 0!==n){var e=t;return e&&e.ownerDocument&&e.ownerDocument.defaultView?e.ownerDocument.defaultView:n}}var a,s=function(){function t(t,e){this._timeoutIds=null,this._immediateIds=null,this._intervalIds=null,this._animationFrameIds=null,this._isDisposed=!1,this._parent=t||null,this._onErrorHandler=e,this._noop=function(){}}return t.prototype.dispose=function(){var t;if(this._isDisposed=!0,this._parent=null,this._timeoutIds){for(t in this._timeoutIds)this._timeoutIds.hasOwnProperty(t)&&this.clearTimeout(parseInt(t,10));this._timeoutIds=null}if(this._immediateIds){for(t in this._immediateIds)this._immediateIds.hasOwnProperty(t)&&this.clearImmediate(parseInt(t,10));this._immediateIds=null}if(this._intervalIds){for(t in this._intervalIds)this._intervalIds.hasOwnProperty(t)&&this.clearInterval(parseInt(t,10));this._intervalIds=null}if(this._animationFrameIds){for(t in this._animationFrameIds)this._animationFrameIds.hasOwnProperty(t)&&this.cancelAnimationFrame(parseInt(t,10));this._animationFrameIds=null}},t.prototype.setTimeout=function(t,e){var o=this,r=0;return this._isDisposed||(this._timeoutIds||(this._timeoutIds={}),r=setTimeout((function(){try{o._timeoutIds&&delete o._timeoutIds[r],t.apply(o._parent)}catch(t){o._logError(t)}}),e),this._timeoutIds[r]=!0),r},t.prototype.clearTimeout=function(t){this._timeoutIds&&this._timeoutIds[t]&&(clearTimeout(t),delete this._timeoutIds[t])},t.prototype.setImmediate=function(t,e){var o=this,r=0,n=i(e);return this._isDisposed||(this._immediateIds||(this._immediateIds={}),r=n.setTimeout((function(){try{o._immediateIds&&delete o._immediateIds[r],t.apply(o._parent)}catch(t){o._logError(t)}}),0),this._immediateIds[r]=!0),r},t.prototype.clearImmediate=function(t,e){var o=i(e);this._immediateIds&&this._immediateIds[t]&&(o.clearTimeout(t),delete this._immediateIds[t])},t.prototype.setInterval=function(t,e){var o=this,r=0;return this._isDisposed||(this._intervalIds||(this._intervalIds={}),r=setInterval((function(){try{t.apply(o._parent)}catch(t){o._logError(t)}}),e),this._intervalIds[r]=!0),r},t.prototype.clearInterval=function(t){this._intervalIds&&this._intervalIds[t]&&(clearInterval(t),delete this._intervalIds[t])},t.prototype.throttle=function(t,e,o){var r=this;if(this._isDisposed)return this._noop;var n,i,a=e||0,s=!0,l=!0,u=0,c=null;o&&"boolean"==typeof o.leading&&(s=o.leading),o&&"boolean"==typeof o.trailing&&(l=o.trailing);var d=function e(o){var d=Date.now(),m=d-u,h=s?a-m:a;return m>=a&&(!o||s)?(u=d,c&&(r.clearTimeout(c),c=null),n=t.apply(r._parent,i)):null===c&&l&&(c=r.setTimeout(e,h)),n};return function(){for(var t=[],e=0;e<arguments.length;e++)t[e]=arguments[e];return i=t,d(!0)}},t.prototype.debounce=function(t,e,o){var r=this;if(this._isDisposed){var n=function(){};return n.cancel=function(){},n.flush=function(){return null},n.pending=function(){return!1},n}var i,a,s=e||0,l=!1,u=!0,c=null,d=0,m=Date.now(),h=null;o&&"boolean"==typeof o.leading&&(l=o.leading),o&&"boolean"==typeof o.trailing&&(u=o.trailing),o&&"number"==typeof o.maxWait&&!isNaN(o.maxWait)&&(c=o.maxWait);var p=function(t){h&&(r.clearTimeout(h),h=null),m=t},f=function(e){p(e),i=t.apply(r._parent,a)},v=function t(e){var o=Date.now(),n=!1;e&&(l&&o-d>=s&&(n=!0),d=o);var a=o-d,p=s-a,v=o-m,I=!1;return null!==c&&(v>=c&&h?I=!0:p=Math.min(p,c-v)),a>=s||I||n?f(o):null!==h&&e||!u||(h=r.setTimeout(t,p)),i},I=function(){return!!h},_=function(){for(var t=[],e=0;e<arguments.length;e++)t[e]=arguments[e];return a=t,v(!0)};return _.cancel=function(){I()&&p(Date.now())},_.flush=function(){return I()&&f(Date.now()),i},_.pending=I,_},t.prototype.requestAnimationFrame=function(t,e){var o=this,r=0,n=i(e);if(!this._isDisposed){this._animationFrameIds||(this._animationFrameIds={});var a=function(){try{o._animationFrameIds&&delete o._animationFrameIds[r],t.apply(o._parent)}catch(t){o._logError(t)}};r=n.requestAnimationFrame?n.requestAnimationFrame(a):n.setTimeout(a,0),this._animationFrameIds[r]=!0}return r},t.prototype.cancelAnimationFrame=function(t,e){var o=i(e);this._animationFrameIds&&this._animationFrameIds[t]&&(o.cancelAnimationFrame?o.cancelAnimationFrame(t):o.clearTimeout(t),delete this._animationFrameIds[t])},t.prototype._logError=function(t){this._onErrorHandler&&this._onErrorHandler(t)},t}();!function(t){t[t.IconButon=0]="IconButon",t[t.ActionButton=1]="ActionButton",t[t.Icon=2]="Icon"}(a||(a={}));var l=o.memo((t=>{var{text:e,disabled:n,onSelected:i,tabIndex:l,ariaLabel:h,setFocus:p,themeJSON:f,renderType:v}=t,I=o.useMemo((()=>{try{return f?(0,r.createTheme)(JSON.parse(f)):void 0}catch(t){console.error("Cannot parse theme",t)}}),[f]),_=o.useRef(null),y=function(){var t,e,r=(t=function(){return new s},void 0===(e=o.useRef()).current&&(e.current={value:t()}),e.current.value);return o.useEffect((function(){return function(){return r.dispose()}}),[r]),r}();o.useEffect((()=>{p&&""!==p&&_&&y.requestAnimationFrame((()=>{var t;null===(t=_.current)||void 0===t||t.focus()}))}),[p,_,y]);var C=v===a.IconButon?r.IconButton:r.ActionButton;return o.createElement(r.ThemeProvider,{applyTo:"none",theme:I,className:c(t)},v===a.Icon&&o.createElement(r.FontIcon,{"aria-label":t.ariaLabel,className:d(t),iconName:t.iconName}),v!==a.Icon&&o.createElement(C,{componentRef:_,styles:m(t),iconProps:u(t),ariaLabel:h,disabled:n,text:e,onClick:i,tabIndex:l}))}));function u(t){var e,o;return{iconName:t.iconName,styles:{root:{color:null!==(e=t.iconColor)&&void 0!==e?e:t.fontColor,fontSize:null!==(o=t.iconSize)&&void 0!==o?o:t.fontSize}}}}function c(t){return(0,r.mergeStyles)({height:t.height,display:"flex",alignItems:"center"})}function d(t){var e,o;return(0,r.mergeStyles)({fontSize:null!==(e=t.iconSize)&&void 0!==e?e:t.fontSize,width:t.width,margin:0,color:null!==(o=t.iconColor)&&void 0!==o?o:t.fontColor,textAlign:t.justify})}function m(t){var e,o,r,n,i,s,l={root:{width:t.width,height:t.height,backgroundColor:null!==(e=t.fillColor)&&void 0!==e?e:"transparent",borderColor:t.borderColor,color:t.fontColor,borderRadius:t.borderRadius,borderWidth:t.fillColor?1:void 0,borderStyle:t.fillColor?"solid":void 0,fontSize:t.fontSize},rootHovered:{backgroundColor:t.hoverFillColor,borderColor:t.hoverBorderColor,color:null!==(o=t.hoverFontColor)&&void 0!==o?o:t.fontColor},icon:{color:null!==(r=t.iconColor)&&void 0!==r?r:t.fontColor,fontSize:null!==(n=t.iconSize)&&void 0!==n?n:t.fontSize},iconHovered:{color:null!==(s=null!==(i=t.hoverIconColor)&&void 0!==i?i:t.hoverFontColor)&&void 0!==s?s:t.fontColor},flexContainer:{justifyContent:t.justify}};return t.renderType===a.Icon&&(l.textContainer={display:"none"}),l}l.displayName="IconComponent";var h={0:"center",1:"left",2:"right"},p={0:a.IconButon,1:a.ActionButton,2:a.Icon};class f{constructor(){this.outputEvent="",this.focusKey="",this.onSelect=()=>{this.outputEvent="OnSelect",this.notifyOutputChanged()}}init(t,e,o,r){this.container=r,this.notifyOutputChanged=e,t.mode.trackContainerResize(!0)}updateView(t){var e,r,n=parseInt(t.mode.allocatedWidth),i=parseInt(t.mode.allocatedHeight),a=null!==(r=null===(e=t.accessibility)||void 0===e?void 0:e.assignedTabIndex)&&void 0!==r?r:void 0,s=t.parameters.InputEvent.raw;return s&&this.inputEvent!==s&&s.startsWith("SetFocus")&&(this.focusKey=s),o.createElement(l,{tabIndex:a,width:n,height:i,setFocus:this.focusKey,disabled:!0===t.mode.isControlDisabled,themeJSON:v(t.parameters.Theme),onSelected:this.onSelect,iconName:I(t.parameters.IconName,"emoji2"),text:I(t.parameters.Text,""),justify:h[t.parameters.TextAlignment.raw],renderType:p[t.parameters.IconType.raw],iconColor:v(t.parameters.IconColor),iconSize:_(t.parameters.IconSize),hoverIconColor:v(t.parameters.HoverIconColor),fontSize:_(t.parameters.FontSize),fontColor:v(t.parameters.FontColor),hoverFontColor:v(t.parameters.HoverFontColor),borderColor:v(t.parameters.BorderColor),hoverBorderColor:v(t.parameters.HoverBorderColor),borderRadius:v(t.parameters.BorderRadius),fillColor:v(t.parameters.FillColor),hoverFillColor:v(t.parameters.HoverFillColor),ariaLabel:v(t.parameters.AccessibilityLabel)})}getOutputs(){return{OutputEvent:this.outputEvent}}destroy(){}}function v(t){return I(t,void 0)}function I(t,e){return t.raw?t.raw:e}function _(t){return t.raw&&t.raw>0?t.raw:void 0}pcf_tools_652ac3f36e1e4bca82eb3c1dc44e6fad=e})();
if (window.ComponentFramework && window.ComponentFramework.registerControl) {
	ComponentFramework.registerControl('PowerCAT.Icon', pcf_tools_652ac3f36e1e4bca82eb3c1dc44e6fad.Icon);
} else {
	var PowerCAT = PowerCAT || {};
	PowerCAT.Icon = pcf_tools_652ac3f36e1e4bca82eb3c1dc44e6fad.Icon;
	pcf_tools_652ac3f36e1e4bca82eb3c1dc44e6fad = undefined;
}