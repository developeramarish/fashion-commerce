(function ($) {
    'use strict'; var counter = 0; $.ajaxTransport('iframe', function (options) {
        if (options.async && (options.type === 'POST' || options.type === 'GET')) {
            var form, iframe; return { send: function (_, completeCallback) {
                form = $('<form style="display:none;"></form>'); iframe = $('<iframe src="javascript:false;" name="iframe-transport-' + (counter += 1) + '"></iframe>').bind('load', function () {
                    var fileInputClones; iframe.unbind('load').bind('load', function () {
                        var response; try { response = iframe.contents(); if (!response.length || !response[0].firstChild) { throw new Error(); } } catch (e) { response = undefined; }
                        completeCallback(200, 'success', { 'iframe': response }); $('<iframe src="javascript:false;"></iframe>').appendTo(form); form.remove();
                    }); form.prop('target', iframe.prop('name')).prop('action', options.url).prop('method', options.type); if (options.formData) { $.each(options.formData, function (index, field) { $('<input type="hidden"/>').prop('name', field.name).val(field.value).appendTo(form); }); }
                    if (options.fileInput && options.fileInput.length && options.type === 'POST') {
                        fileInputClones = options.fileInput.clone(); options.fileInput.after(function (index) { return fileInputClones[index]; }); if (options.paramName) { options.fileInput.each(function () { $(this).prop('name', options.paramName); }); }
                        form.append(options.fileInput).prop('enctype', 'multipart/form-data').prop('encoding', 'multipart/form-data');
                    }
                    form.submit(); if (fileInputClones && fileInputClones.length) { options.fileInput.each(function (index, input) { var clone = $(fileInputClones[index]); $(input).prop('name', clone.prop('name')); clone.replaceWith(input); }); } 
                }); form.append(iframe).appendTo(document.body);
            }, abort: function () {
                if (iframe) { iframe.unbind('load').prop('src', 'javascript'.concat(':false;')); }
                if (form) { form.remove(); } 
            } 
            };
        } 
    }); $.ajaxSetup({ converters: { 'iframe text': function (iframe) { return $(iframe[0].body).text(); }, 'iframe json': function (iframe) { return $.parseJSON($(iframe[0].body).text()); }, 'iframe html': function (iframe) { return $(iframe[0].body).html(); }, 'iframe script': function (iframe) { return $.globalEval($(iframe[0].body).text()); } } });
} (jQuery));