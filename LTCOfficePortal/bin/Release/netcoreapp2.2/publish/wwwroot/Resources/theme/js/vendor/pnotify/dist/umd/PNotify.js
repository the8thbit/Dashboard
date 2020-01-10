!function(t,e){if("function"==typeof define&&define.amd)define("PNotify",["exports"],e);else if("undefined"!=typeof exports)e(exports);else{var i={};e(i),t.PNotify=i}}(this,function(t){"use strict";Object.defineProperty(t,"__esModule",{value:!0});var e=Object.assign||function(t){for(var e=1;e<arguments.length;e++){var i=arguments[e];for(var n in i)Object.prototype.hasOwnProperty.call(i,n)&&(t[n]=i[n])}return t},i="function"==typeof Symbol&&"symbol"==typeof Symbol.iterator?function(t){return typeof t}:function(t){return t&&"function"==typeof Symbol&&t.constructor===Symbol&&t!==Symbol.prototype?"symbol":typeof t},n=void 0,o=void 0,s=function(){n.defaultStack.context=document.body,window.addEventListener("resize",function(){o&&clearTimeout(o),o=setTimeout(function(){n.positionAll()},10)})},r=function(t){t.overlay.parentNode&&t.overlay.parentNode.removeChild(t.overlay)},a=function(t,e){return"object"!==(void 0===t?"undefined":i(t))&&(t={text:t}),e&&(t.type=e),{target:document.body,data:t}};var c={runModules:function(t){if("init"===t){for(var i in n.modules)if(n.modules.hasOwnProperty(i)&&"function"==typeof n.modules[i].init){var o=n.modules[i].init(this);this.initModule(o)}}else{var s=this.get("_modules");for(var r in s)if(s.hasOwnProperty(r)){var a=e({_notice:this,_options:this.get()},this.get("modules")[r]);s[r].set(a),"function"==typeof s[r][t]&&s[r][t]()}}},initModule:function(t){var i=this.get("modules");i.hasOwnProperty(t.constructor.key)||(i[t.constructor.key]={});var n=e({_notice:this,_options:this.get()},i[t.constructor.key]);t.initModule(n),this.get("_modules")[t.constructor.key]=t},update:function(t){var e=this.get("hide"),i=this.get("icon");this.set(t),this.runModules("update"),this.get("hide")?e||this.queueClose():this.cancelClose(),this.queuePosition();var n=this.get("icon");return n!==i&&(!0===n&&"fontawesome5"===this.get("icons")||"string"==typeof n&&n.match(/(^| )fa[srlb]($| )/))&&(this.set({icon:!1}),this.set({icon:n})),this},open:function(){var t=this;if("opening"!==this.get("_state")){if("open"!==this.get("_state")){this.set({_state:"opening",_animatingClass:"ui-pnotify-initial-hidden"}),this.runModules("beforeOpen");var e=this.get("stack");if(!this.refs.elem.parentNode||e&&e.context&&e.context!==this.refs.elem.parentNode)if(e&&e.context)e.context.appendChild(this.refs.elem);else{if(!document.body)throw new Error("No context to open this notice in.");document.body.appendChild(this.refs.elem)}return setTimeout(function(){e&&(e.animation=!1,n.positionAll(),e.animation=!0),t.animateIn(function(){t.get("hide")&&t.queueClose(),t.set({_state:"open"}),t.runModules("afterOpen")})},0),this}this.get("hide")&&this.queueClose()}},remove:function(t){return this.close(t)},close:function(t){var e=this;if("closing"!==this.get("_state")&&"closed"!==this.get("_state"))return this.set({_state:"closing",_timerHide:!!t}),this.runModules("beforeClose"),this.get("_timer")&&clearTimeout&&(clearTimeout(this.get("_timer")),this.set({_timer:null})),this.animateOut(function(){if(e.set({_state:"closed"}),e.runModules("afterClose"),e.queuePosition(),e.get("remove")&&e.refs.elem.parentNode.removeChild(e.refs.elem),e.runModules("beforeDestroy"),e.get("destroy")&&null!==n.notices){var t=n.notices.indexOf(e);-1!==t&&n.notices.splice(t,1)}e.runModules("afterDestroy")}),this},animateIn:function(t){var e=this;this.set({_animating:"in"});var i=function i(){if(e.refs.elem.removeEventListener("transitionend",i),e.get("_animTimer")&&clearTimeout(e.get("_animTimer")),"in"===e.get("_animating")){var n=e.get("_moduleIsNoticeOpen");if(!n){var o=e.refs.elem.getBoundingClientRect();for(var s in o)if(o[s]>0){n=!0;break}}n?(t&&t.call(),e.set({_animating:!1})):e.set({_animTimer:setTimeout(i,40)})}};"fade"===this.get("animation")?(this.refs.elem.addEventListener("transitionend",i),this.set({_animatingClass:"ui-pnotify-in"}),this.refs.elem.style.opacity,this.set({_animatingClass:"ui-pnotify-in ui-pnotify-fade-in"}),this.set({_animTimer:setTimeout(i,650)})):(this.set({_animatingClass:"ui-pnotify-in"}),i())},animateOut:function(t){var e=this;this.set({_animating:"out"});var i=function i(){if(e.refs.elem.removeEventListener("transitionend",i),e.get("_animTimer")&&clearTimeout(e.get("_animTimer")),"out"===e.get("_animating")){var o=e.get("_moduleIsNoticeOpen");if(!o){var s=e.refs.elem.getBoundingClientRect();for(var a in s)if(s[a]>0){o=!0;break}}if(e.refs.elem.style.opacity&&"0"!=e.refs.elem.style.opacity&&o)e.set({_animTimer:setTimeout(i,40)});else{e.set({_animatingClass:""});var c=e.get("stack");if(c&&c.overlay){for(var l=!1,f=0;f<n.notices.length;f++){var u=n.notices[f];if(u!=e&&u.get("stack")===c&&"closed"!==u.get("_state")){l=!0;break}}l||r(c)}t&&t.call(),e.set({_animating:!1})}}};"fade"===this.get("animation")?(this.refs.elem.addEventListener("transitionend",i),this.set({_animatingClass:"ui-pnotify-in"}),this.set({_animTimer:setTimeout(i,650)})):(this.set({_animatingClass:""}),i())},position:function(){var t=this.get("stack"),e=this.refs.elem;if(t){if(t.context||(t.context=document.body),"number"!=typeof t.nextpos1&&(t.nextpos1=t.firstpos1),"number"!=typeof t.nextpos2&&(t.nextpos2=t.firstpos2),"number"!=typeof t.addpos2&&(t.addpos2=0),!e.classList.contains("ui-pnotify-in")&&!e.classList.contains("ui-pnotify-initial-hidden"))return this;var i,o,s;t.modal&&(t.overlay||(o=t,(s=document.createElement("div")).classList.add("ui-pnotify-modal-overlay"),o.context!==document.body&&(s.style.height=o.context.scrollHeight+"px",s.style.width=o.context.scrollWidth+"px"),s.addEventListener("click",function(){o.overlayClose&&n.closeStack(o)}),o.overlay=s),(i=t).overlay.parentNode!==i.context&&(i.overlay=i.context.insertBefore(i.overlay,i.context.firstChild)));e.getBoundingClientRect();t.animation&&this.set({_moveClass:"ui-pnotify-move"});var r=t.context===document.body?window.innerHeight:t.context.scrollHeight,a=t.context===document.body?window.innerWidth:t.context.scrollWidth,c=void 0;if(t.dir1){c={down:"top",up:"bottom",left:"right",right:"left"}[t.dir1];var l=void 0;switch(t.dir1){case"down":l=e.offsetTop;break;case"up":l=r-e.scrollHeight-e.offsetTop;break;case"left":l=a-e.scrollWidth-e.offsetLeft;break;case"right":l=e.offsetLeft}void 0===t.firstpos1&&(t.firstpos1=l,t.nextpos1=t.firstpos1)}if(t.dir1&&t.dir2){var f={down:"top",up:"bottom",left:"right",right:"left"}[t.dir2],u=void 0;switch(t.dir2){case"down":u=e.offsetTop;break;case"up":u=r-e.scrollHeight-e.offsetTop;break;case"left":u=a-e.scrollWidth-e.offsetLeft;break;case"right":u=e.offsetLeft}void 0===t.firstpos2&&(t.firstpos2=u,t.nextpos2=t.firstpos2);var d=t.nextpos1+e.offsetHeight+(void 0===t.spacing1?25:t.spacing1),p=t.nextpos1+e.offsetWidth+(void 0===t.spacing1?25:t.spacing1);switch((("down"===t.dir1||"up"===t.dir1)&&d>r||("left"===t.dir1||"right"===t.dir1)&&p>a)&&(t.nextpos1=t.firstpos1,t.nextpos2+=t.addpos2+(void 0===t.spacing2?25:t.spacing2),t.addpos2=0),"number"==typeof t.nextpos2&&(e.style[f]=t.nextpos2+"px",t.animation||e.style[f]),t.dir2){case"down":case"up":e.offsetHeight+(parseFloat(e.style.marginTop,10)||0)+(parseFloat(e.style.marginBottom,10)||0)>t.addpos2&&(t.addpos2=e.offsetHeight);break;case"left":case"right":e.offsetWidth+(parseFloat(e.style.marginLeft,10)||0)+(parseFloat(e.style.marginRight,10)||0)>t.addpos2&&(t.addpos2=e.offsetWidth)}}else if(t.dir1){var h=void 0,m=void 0;switch(t.dir1){case"down":case"up":m=["left","right"],h=t.context.scrollWidth/2-e.offsetWidth/2;break;case"left":case"right":m=["top","bottom"],h=r/2-e.offsetHeight/2}e.style[m[0]]=h+"px",e.style[m[1]]="auto",t.animation||e.style[m[0]]}if(t.dir1)switch("number"==typeof t.nextpos1&&(e.style[c]=t.nextpos1+"px",t.animation||e.style[c]),t.dir1){case"down":case"up":t.nextpos1+=e.offsetHeight+(void 0===t.spacing1?25:t.spacing1);break;case"left":case"right":t.nextpos1+=e.offsetWidth+(void 0===t.spacing1?25:t.spacing1)}else{var y=a/2-e.offsetWidth/2,g=r/2-e.offsetHeight/2;e.style.left=y+"px",e.style.top=g+"px",t.animation||e.style.left}return this}},queuePosition:function(t){return o&&clearTimeout(o),t||(t=10),o=setTimeout(function(){n.positionAll()},t),this},cancelRemove:function(){return this.cancelClose()},cancelClose:function(){return this.get("_timer")&&clearTimeout(this.get("_timer")),this.get("_animTimer")&&clearTimeout(this.get("_animTimer")),"closing"===this.get("_state")&&this.set({_state:"open",_animating:!1,_animatingClass:"fade"===this.get("animation")?"ui-pnotify-in ui-pnotify-fade-in":"ui-pnotify-in"}),this},queueRemove:function(){return this.queueClose()},queueClose:function(){var t=this;return this.cancelClose(),this.set({_timer:setTimeout(function(){return t.close(!0)},isNaN(this.get("delay"))?0:this.get("delay"))}),this},addModuleClass:function(){for(var t=this.get("_moduleClasses"),e=arguments.length,i=Array(e),n=0;n<e;n++)i[n]=arguments[n];for(var o=0;o<i.length;o++){var s=i[o];-1===t.indexOf(s)&&t.push(s)}this.set({_moduleClasses:t})},removeModuleClass:function(){for(var t=this.get("_moduleClasses"),e=arguments.length,i=Array(e),n=0;n<e;n++)i[n]=arguments[n];for(var o=0;o<i.length;o++){var s=i[o],r=t.indexOf(s);-1!==r&&t.splice(r,1)}this.set({_moduleClasses:t})},hasModuleClass:function(){for(var t=this.get("_moduleClasses"),e=arguments.length,i=Array(e),n=0;n<e;n++)i[n]=arguments[n];for(var o=0;o<i.length;o++){var s=i[o];if(-1===t.indexOf(s))return!1}return!0}};function l(t,e,i,n,o){var s;if(i)var r=new i({root:o.root});return r&&r.on("init",function(t){o.initModule(t.module)}),{c:function(){s=O(),r&&r._fragment.c()},m:function(t,e){T(s,t,e),r&&r._mount(t,e)},u:function(){N(s),r&&r._unmount()},d:function(){r&&r.destroy(!1)}}}function f(t,e){var i,n,o,s;return{c:function(){i=v("div"),n=v("span"),this.h()},h:function(){n.className=o=!0===t.icon?t._icons[t.type]?t._icons[t.type]:"":t.icon,i.className=s="ui-pnotify-icon "+(t._styles.icon?t._styles.icon:"")},m:function(t,e){T(i,t,e),b(n,i)},p:function(t,e){(t.icon||t._icons||t.type)&&o!==(o=!0===e.icon?e._icons[e.type]?e._icons[e.type]:"":e.icon)&&(n.className=o),t._styles&&s!==(s="ui-pnotify-icon "+(e._styles.icon?e._styles.icon:""))&&(i.className=s)},u:function(){N(i)},d:A}}function u(t,e){var i,n;return{c:function(){i=v("noscript"),n=v("noscript")},m:function(e,o){T(i,e,o),i.insertAdjacentHTML("afterend",t.title),T(n,e,o)},p:function(t,e){t.title&&(L(i,n),i.insertAdjacentHTML("afterend",e.title))},u:function(){L(i,n),N(i),N(n)},d:A}}function d(t,e){var i;return{c:function(){i=x(t.title)},m:function(t,e){T(i,t,e)},p:function(t,e){t.title&&(i.data=e.title)},u:function(){N(i)},d:A}}function p(t,e){var i,n;return{c:function(){i=v("noscript"),n=v("noscript")},m:function(e,o){T(i,e,o),i.insertAdjacentHTML("afterend",t.text),T(n,e,o)},p:function(t,e){t.text&&(L(i,n),i.insertAdjacentHTML("afterend",e.text))},u:function(){L(i,n),N(i),N(n)},d:A}}function h(t,e){var i;return{c:function(){i=x(t.text)},m:function(t,e){T(i,t,e)},p:function(t,e){t.text&&(i.data=e.text)},u:function(){N(i)},d:A}}function m(t,e,i,n,o){var s;if(i)var r=new i({root:o.root});return r&&r.on("init",function(t){o.initModule(t.module)}),{c:function(){s=O(),r&&r._fragment.c()},m:function(t,e){T(s,t,e),r&&r._mount(t,e)},u:function(){N(s),r&&r._unmount()},d:function(){r&&r.destroy(!1)}}}function y(t){return t.titleTrusted?u:d}function g(t){return t.textTrusted?p:h}function _(t){var i,o,s,r;o=t,(i=this)._observers={pre:E(),post:E()},i._handlers=E(),i._bind=o._bind,i.options=o,i.root=o.root||i,i.store=i.root.store||o.store,this.refs={},this._state=S(((s=e({_state:"initializing",_timer:null,_animTimer:null,_animating:!1,_animatingClass:"",_moveClass:"",_timerHide:!1,_moduleClasses:[],_moduleIsNoticeOpen:!1,_modules:{},_modulesPrependContainer:n.modulesPrependContainer,_modulesAppendContainer:n.modulesAppendContainer},n.defaults)).modules=e({},n.defaults.modules),s),t.data),this._recompute({styling:1,icons:1},this._state),document.getElementById("svelte-3059224252-style")||((r=v("style")).id="svelte-3059224252-style",r.textContent='body > .ui-pnotify{position:fixed;z-index:100040}body > .ui-pnotify.ui-pnotify-modal{z-index:100042}.ui-pnotify{position:absolute;height:auto;z-index:1;display:none}.ui-pnotify.ui-pnotify-modal{z-index:3}.ui-pnotify.ui-pnotify-in{display:block}.ui-pnotify.ui-pnotify-initial-hidden{display:block;visibility:hidden}.ui-pnotify.ui-pnotify-move{transition:left .5s ease, top .5s ease, right .5s ease, bottom .5s ease}.ui-pnotify.ui-pnotify-fade-slow{transition:opacity .4s linear;opacity:0}.ui-pnotify.ui-pnotify-fade-slow.ui-pnotify.ui-pnotify-move{transition:opacity .4s linear, left .5s ease, top .5s ease, right .5s ease, bottom .5s ease}.ui-pnotify.ui-pnotify-fade-normal{transition:opacity .25s linear;opacity:0}.ui-pnotify.ui-pnotify-fade-normal.ui-pnotify.ui-pnotify-move{transition:opacity .25s linear, left .5s ease, top .5s ease, right .5s ease, bottom .5s ease}.ui-pnotify.ui-pnotify-fade-fast{transition:opacity .1s linear;opacity:0}.ui-pnotify.ui-pnotify-fade-fast.ui-pnotify.ui-pnotify-move{transition:opacity .1s linear, left .5s ease, top .5s ease, right .5s ease, bottom .5s ease}.ui-pnotify.ui-pnotify-fade-in{opacity:1}.ui-pnotify .ui-pnotify-shadow{-webkit-box-shadow:0px 6px 28px 0px rgba(0,0,0,0.1);-moz-box-shadow:0px 6px 28px 0px rgba(0,0,0,0.1);box-shadow:0px 6px 28px 0px rgba(0,0,0,0.1)}.ui-pnotify-container{background-position:0 0;padding:.8em;height:100%;margin:0}.ui-pnotify-container:after{content:" ";visibility:hidden;display:block;height:0;clear:both}.ui-pnotify-container.ui-pnotify-sharp{-webkit-border-radius:0;-moz-border-radius:0;border-radius:0}.ui-pnotify-title{display:block;white-space:pre-line;margin-bottom:.4em;margin-top:0}.ui-pnotify.ui-pnotify-with-icon .ui-pnotify-title,.ui-pnotify.ui-pnotify-with-icon .ui-pnotify-text{margin-left:24px}[dir=rtl] .ui-pnotify.ui-pnotify-with-icon .ui-pnotify-title,[dir=rtl] .ui-pnotify.ui-pnotify-with-icon .ui-pnotify-text{margin-right:24px;margin-left:0}.ui-pnotify-title-bs4{font-size:1.2rem}.ui-pnotify-text{display:block;white-space:pre-line}.ui-pnotify-icon,.ui-pnotify-icon span{display:block;float:left}[dir=rtl] .ui-pnotify-icon,[dir=rtl] .ui-pnotify-icon span{float:right}.ui-pnotify-icon-bs3 > span{position:relative;top:2px}.ui-pnotify-icon-bs4 > span{position:relative;top:4px}.ui-pnotify-modal-overlay{background-color:rgba(0, 0, 0, .4);top:0;left:0;position:absolute;height:100%;width:100%;z-index:2}body > .ui-pnotify-modal-overlay{position:fixed;z-index:100041}',b(r,document.head));var a=function(){var t=this;this.on("mouseenter",function(e){if(t.get("mouseReset")&&"out"===t.get("_animating")){if(!t.get("_timerHide"))return;t.cancelClose()}t.get("hide")&&t.get("mouseReset")&&t.cancelClose()}),this.on("mouseleave",function(e){t.get("hide")&&t.get("mouseReset")&&"out"!==t.get("_animating")&&t.queueClose(),n.positionAll()});var e=this.get("stack");e&&"top"===e.push?n.notices.splice(0,0,this):n.notices.push(this),this.runModules("init"),this.set({_state:"closed"}),this.get("autoDisplay")&&this.open()}.bind(this);t.root||(this._oncreate=[],this._beforecreate=[],this._aftercreate=[]),this._fragment=function(t,e){for(var i,n,o,s,r,a,c,u,d,p,h,_,O,A=t._modulesPrependContainer,L=[],S=0;S<A.length;S+=1)L[S]=l(0,0,A[S],0,e);var P=!1!==t.icon&&f(t),j=y(t),E=j(t,e),W=g(t),z=W(t,e),R=t._modulesAppendContainer,q=[];for(S=0;S<R.length;S+=1)q[S]=m(0,0,R[S],0,e);function B(t){e.fire("mouseover",t)}function I(t){e.fire("mouseout",t)}function D(t){e.fire("mouseenter",t)}function F(t){e.fire("mouseleave",t)}function V(t){e.fire("mousemove",t)}function $(t){e.fire("mousedown",t)}function G(t){e.fire("mouseup",t)}function J(t){e.fire("click",t)}function K(t){e.fire("dblclick",t)}function Q(t){e.fire("focus",t)}function U(t){e.fire("blur",t)}function X(t){e.fire("touchstart",t)}function Y(t){e.fire("touchmove",t)}function Z(t){e.fire("touchend",t)}function tt(t){e.fire("touchcancel",t)}return{c:function(){i=v("div"),n=v("div");for(var t=0;t<L.length;t+=1)L[t].c();for(o=x("\n    "),P&&P.c(),s=x("\n    "),r=v("h4"),E.c(),c=x("\n    "),u=v("div"),z.c(),p=x("\n    "),t=0;t<q.length;t+=1)q[t].c();this.h()},h:function(){r.className=a="ui-pnotify-title "+(t._styles.title?t._styles.title:""),C(r,"display",!1===t.title?"none":"block"),u.className=d="ui-pnotify-text "+(t._styles.text?t._styles.text:""),C(u,"display",!1===t.text?"none":"block"),w(u,"role","alert"),n.className=h="\n        ui-pnotify-container\n        "+(t._styles.container?t._styles.container:"")+"\n        "+(t._styles[t.type]?t._styles[t.type]:"")+"\n        "+t.cornerClass+"\n        "+(t.shadow?"ui-pnotify-shadow":"")+"\n      ",n.style.cssText=_="\n        "+("string"==typeof t.width?"width: "+t.width+";":"")+"\n        "+("string"==typeof t.minHeight?"min-height: "+t.minHeight+";":"")+"\n      ",w(n,"role","alert"),i.className=O="\n      ui-pnotify\n      "+(!1!==t.icon?"ui-pnotify-with-icon":"")+"\n      "+(t._styles.element?t._styles.element:"")+"\n      "+t.addClass+"\n      "+t._animatingClass+"\n      "+t._moveClass+"\n      "+("fade"===t.animation?"ui-pnotify-fade-"+t.animateSpeed:"")+"\n      "+(t.stack&&t.stack.modal?"ui-pnotify-modal":"")+"\n      "+t._moduleClasses.join(" ")+"\n    ",w(i,"aria-live","assertive"),w(i,"role","alertdialog"),w(i,"ui-pnotify",!0),k(i,"mouseover",B),k(i,"mouseout",I),k(i,"mouseenter",D),k(i,"mouseleave",F),k(i,"mousemove",V),k(i,"mousedown",$),k(i,"mouseup",G),k(i,"click",J),k(i,"dblclick",K),k(i,"focus",Q),k(i,"blur",U),k(i,"touchstart",X),k(i,"touchmove",Y),k(i,"touchend",Z),k(i,"touchcancel",tt)},m:function(t,a){T(i,t,a),b(n,i);for(var l=0;l<L.length;l+=1)L[l].m(n,null);for(b(o,n),P&&P.m(n,null),b(s,n),b(r,n),E.m(r,null),e.refs.titleContainer=r,b(c,n),b(u,n),z.m(u,null),e.refs.textContainer=u,b(p,n),l=0;l<q.length;l+=1)q[l].m(n,null);e.refs.container=n,e.refs.elem=i},p:function(t,c){var p=c._modulesPrependContainer;if(t._modulesPrependContainer){for(var v=L.length;v<p.length;v+=1)L[v]=l(0,0,p[v],0,e),L[v].c(),L[v].m(n,o);for(;v<L.length;v+=1)L[v].u(),L[v].d();L.length=p.length}!1!==c.icon?P?P.p(t,c):((P=f(c)).c(),P.m(n,s)):P&&(P.u(),P.d(),P=null),j===(j=y(c))&&E?E.p(t,c):(E.u(),E.d(),(E=j(c,e)).c(),E.m(r,null)),t._styles&&a!==(a="ui-pnotify-title "+(c._styles.title?c._styles.title:""))&&(r.className=a),t.title&&C(r,"display",!1===c.title?"none":"block"),W===(W=g(c))&&z?z.p(t,c):(z.u(),z.d(),(z=W(c,e)).c(),z.m(u,null)),t._styles&&d!==(d="ui-pnotify-text "+(c._styles.text?c._styles.text:""))&&(u.className=d),t.text&&C(u,"display",!1===c.text?"none":"block");var b=c._modulesAppendContainer;if(t._modulesAppendContainer){for(v=q.length;v<b.length;v+=1)q[v]=m(0,0,b[v],0,e),q[v].c(),q[v].m(n,null);for(;v<q.length;v+=1)q[v].u(),q[v].d();q.length=b.length}(t._styles||t.type||t.cornerClass||t.shadow)&&h!==(h="\n        ui-pnotify-container\n        "+(c._styles.container?c._styles.container:"")+"\n        "+(c._styles[c.type]?c._styles[c.type]:"")+"\n        "+c.cornerClass+"\n        "+(c.shadow?"ui-pnotify-shadow":"")+"\n      ")&&(n.className=h),(t.width||t.minHeight)&&_!==(_="\n        "+("string"==typeof c.width?"width: "+c.width+";":"")+"\n        "+("string"==typeof c.minHeight?"min-height: "+c.minHeight+";":"")+"\n      ")&&(n.style.cssText=_),(t.icon||t._styles||t.addClass||t._animatingClass||t._moveClass||t.animation||t.animateSpeed||t.stack||t._moduleClasses)&&O!==(O="\n      ui-pnotify\n      "+(!1!==c.icon?"ui-pnotify-with-icon":"")+"\n      "+(c._styles.element?c._styles.element:"")+"\n      "+c.addClass+"\n      "+c._animatingClass+"\n      "+c._moveClass+"\n      "+("fade"===c.animation?"ui-pnotify-fade-"+c.animateSpeed:"")+"\n      "+(c.stack&&c.stack.modal?"ui-pnotify-modal":"")+"\n      "+c._moduleClasses.join(" ")+"\n    ")&&(i.className=O)},u:function(){N(i);for(var t=0;t<L.length;t+=1)L[t].u();for(P&&P.u(),E.u(),z.u(),t=0;t<q.length;t+=1)q[t].u()},d:function(){H(L),P&&P.d(),E.d(),e.refs.titleContainer===r&&(e.refs.titleContainer=null),z.d(),e.refs.textContainer===u&&(e.refs.textContainer=null),H(q),e.refs.container===n&&(e.refs.container=null),M(i,"mouseover",B),M(i,"mouseout",I),M(i,"mouseenter",D),M(i,"mouseleave",F),M(i,"mousemove",V),M(i,"mousedown",$),M(i,"mouseup",G),M(i,"click",J),M(i,"dblclick",K),M(i,"focus",Q),M(i,"blur",U),M(i,"touchstart",X),M(i,"touchmove",Y),M(i,"touchend",Z),M(i,"touchcancel",tt),e.refs.elem===i&&(e.refs.elem=null)}}}(this._state,this),this.root._oncreate.push(a),t.target&&(this._fragment.c(),this._fragment.m(t.target,t.anchor||null),this._lock=!0,P(this._beforecreate),P(this._oncreate),P(this._aftercreate),this._lock=!1)}function v(t){return document.createElement(t)}function b(t,e){e.appendChild(t)}function x(t){return document.createTextNode(t)}function C(t,e,i){t.style.setProperty(e,i)}function w(t,e,i){t.setAttribute(e,i)}function k(t,e,i){t.addEventListener(e,i,!1)}function T(t,e,i){e.insertBefore(t,i)}function N(t){t.parentNode.removeChild(t)}function H(t){for(var e=0;e<t.length;e+=1)t[e]&&t[e].d()}function M(t,e,i){t.removeEventListener(e,i,!1)}function O(){return document.createComment("")}function A(){}function L(t,e){for(;t.nextSibling&&t.nextSibling!==e;)t.parentNode.removeChild(t.nextSibling)}function S(t){for(var e,i,n=1,o=arguments.length;n<o;n++)for(e in i=arguments[n])t[e]=i[e];return t}function P(t){for(;t&&t.length;)t.shift()()}function j(t){this.destroy=A,this.fire("destroy"),this.set=this.get=A,!1!==t&&this._fragment.u(),this._fragment.d(),this._fragment=this._state=null}function E(){return Object.create(null)}function W(t,e,i,n,o){for(var s in e)if(i[s]){var r=n[s],a=o[s],c=e[s];if(c)for(var l=0;l<c.length;l+=1){var f=c[l];f.__calling||(f.__calling=!0,f.call(t,r,a),f.__calling=!1)}}}S(_.prototype,c,{destroy:j,get:function(t){return t?this._state[t]:this._state},fire:function(t,e){var i=t in this._handlers&&this._handlers[t].slice();if(!i)return;for(var n=0;n<i.length;n+=1)i[n].call(this,e)},observe:function(t,e,i){var n=i&&i.defer?this._observers.post:this._observers.pre;(n[t]||(n[t]=[])).push(e),i&&!1===i.init||(e.__calling=!0,e.call(this,this._state[t]),e.__calling=!1);return{cancel:function(){var i=n[t].indexOf(e);~i&&n[t].splice(i,1)}}},on:function(t,e){if("teardown"===t)return this.on("destroy",e);var i=this._handlers[t]||(this._handlers[t]=[]);return i.push(e),{cancel:function(){var t=i.indexOf(e);~t&&i.splice(t,1)}}},set:function(t){if(this._set(S({},t)),this.root._lock)return;this.root._lock=!0,P(this.root._beforecreate),P(this.root._oncreate),P(this.root._aftercreate),this.root._lock=!1},teardown:j,_set:function(t){var e=this._state,i={},n=!1;for(var o in t)this._differs(t[o],e[o])&&(i[o]=n=!0);if(!n)return;this._state=S({},e,t),this._recompute(i,this._state),this._bind&&this._bind(i,this._state);this._fragment&&(W(this,this._observers.pre,i,this._state,e),this._fragment.p(i,this._state),W(this,this._observers.post,i,this._state,e))},_mount:function(t,e){this._fragment.m(t,e)},_unmount:function(){this._fragment&&this._fragment.u()},_differs:function(t,e){return t!=t?e==e:t!==e||t&&"object"===(void 0===t?"undefined":i(t))||"function"==typeof t}}),_.prototype._recompute=function(t,e){var o,s;t.styling&&this._differs(e._styles,e._styles="object"===(void 0===(o=e.styling)?"undefined":i(o))?o:n.styling[o])&&(t._styles=!0),t.icons&&this._differs(e._icons,e._icons="object"===(void 0===(s=e.icons)?"undefined":i(s))?s:n.icons[s])&&(t._icons=!0)},(n=_).VERSION="4.0.0-alpha.2",n.defaultStack={dir1:"down",dir2:"left",firstpos1:25,firstpos2:25,spacing1:36,spacing2:36,push:"bottom",context:window&&document.body},n.defaults={title:!1,titleTrusted:!1,text:!1,textTrusted:!1,styling:"brighttheme",icons:"brighttheme",addClass:"",cornerClass:"",autoDisplay:!0,width:"360px",minHeight:"16px",type:"notice",icon:!0,animation:"fade",animateSpeed:"normal",shadow:!0,hide:!0,delay:8e3,mouseReset:!0,remove:!0,destroy:!0,stack:n.defaultStack,modules:{}},n.notices=[],n.modules={},n.modulesPrependContainer=[],n.modulesAppendContainer=[],n.alert=function(t){return new n(a(t))},n.notice=function(t){return new n(a(t,"notice"))},n.info=function(t){return new n(a(t,"info"))},n.success=function(t){return new n(a(t,"success"))},n.error=function(t){return new n(a(t,"error"))},n.removeAll=function(){n.closeAll()},n.closeAll=function(){for(var t=0;t<n.notices.length;t++)n.notices[t].close&&n.notices[t].close(!1)},n.removeStack=function(t){n.closeStack(t)},n.closeStack=function(t){if(!1!==t)for(var e=0;e<n.notices.length;e++)n.notices[e].close&&n.notices[e].get("stack")===t&&n.notices[e].close(!1)},n.positionAll=function(){if(o&&clearTimeout(o),o=null,n.notices.length>0){for(var t=0;t<n.notices.length;t++){var e=n.notices[t].get("stack");e&&(e.overlay&&r(e),e.nextpos1=e.firstpos1,e.nextpos2=e.firstpos2,e.addpos2=0)}for(var i=0;i<n.notices.length;i++)n.notices[i].position()}else delete n.defaultStack.nextpos1,delete n.defaultStack.nextpos2},n.styling={brighttheme:{container:"brighttheme",notice:"brighttheme-notice",info:"brighttheme-info",success:"brighttheme-success",error:"brighttheme-error"},bootstrap3:{container:"alert",notice:"alert-warning",info:"alert-info",success:"alert-success",error:"alert-danger",icon:"ui-pnotify-icon-bs3"},bootstrap4:{container:"alert",notice:"alert-warning",info:"alert-info",success:"alert-success",error:"alert-danger",icon:"ui-pnotify-icon-bs4",title:"ui-pnotify-title-bs4"}},n.icons={brighttheme:{notice:"brighttheme-icon-notice",info:"brighttheme-icon-info",success:"brighttheme-icon-success",error:"brighttheme-icon-error"},bootstrap3:{notice:"glyphicon glyphicon-exclamation-sign",info:"glyphicon glyphicon-info-sign",success:"glyphicon glyphicon-ok-sign",error:"glyphicon glyphicon-warning-sign"},fontawesome4:{notice:"fa fa-exclamation-circle",info:"fa fa-info-circle",success:"fa fa-check-circle",error:"fa fa-exclamation-triangle"},fontawesome5:{notice:"fas fa-exclamation-circle",info:"fas fa-info-circle",success:"fas fa-check-circle",error:"fas fa-exclamation-triangle"}},window&&document.body?s():document.addEventListener("DOMContentLoaded",s),t.default=_});
//# sourceMappingURL=PNotify.js.map